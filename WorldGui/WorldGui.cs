using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WorldGuiLibrary.Services;
using WorldGuiLibrary.Services.Interfaces;

namespace WorldGui
{
    public partial class WorldGui : Form
    {
        private const string _placeHolderCountry = "Søk på Country Name";
        private const string _placeHolderCityAndLanguage = "Søk på Country Code";

        // static variabler starter med "s_"
        private const string s_countryFileName = @"Files\Country.csv";
        private const string s_cityFileName = @"Files\City.csv";
        private const string s_countryLanguageFileName = @"Files\CountryLanguage.csv";

        private IWorldDataService _worldDataService = new WorldDataService();

        public WorldGui()
        {
            InitializeComponent();

            // laster inn data
            _worldDataService.LoadData(s_countryFileName, s_cityFileName, s_countryLanguageFileName);
            foreach (var error in _worldDataService.GetErrors())
            {
                listErrors.Items.Add(error);
            }
                

            dataGridWorld.DataSource = _worldDataService.GetAllCountries();

            radioBtnCountry.Checked = true;
            txtFilter.PlaceholderText = _placeHolderCountry;

            // setter opp events
            radioBtnCountry.CheckedChanged += RadioBtn_CheckedChanged;
            radioBtnCities.CheckedChanged += RadioBtn_CheckedChanged;
            radioBtnCountryLanguage.CheckedChanged += RadioBtn_CheckedChanged;

            ExpandTreeView();

        }

        private void ExpandTreeView()
        {
            var countries = _worldDataService.GetAllCountries();

            foreach (var country in countries)
            {
                TreeNode node = new TreeNode();
                node.Text = country.Name;

                var cities = _worldDataService.GetAllCities().Where(c => c.CountryCode.ToLower().Equals(country.Code.ToLower()));

                foreach (var city in cities)
                {
                    TreeNode cityNode = new TreeNode();
                    cityNode.Text = city.Name;
                    node.Nodes.Add(cityNode);
                }
                treeViewWorld.Nodes.Add(node);
            }

        }

        private void RadioBtn_CheckedChanged(object? sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;
            if (radioBtnCountry.Checked)
            {
                dataGridWorld.DataSource = _worldDataService.GetAllCountries();
                txtFilter.PlaceholderText = _placeHolderCountry;
                return;
            }

            if (radioBtnCities.Checked)
            {
                dataGridWorld.DataSource = _worldDataService.GetAllCities();
                txtFilter.PlaceholderText = _placeHolderCityAndLanguage;
                return;
            }

            if (radioBtnCountryLanguage.Checked)
            {
                dataGridWorld.DataSource = _worldDataService.GetAllCountryLanguages();
                txtFilter.PlaceholderText = _placeHolderCityAndLanguage;
                return;
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (radioBtnCountry.Checked)
            {
                if (txtFilter.Text.Length > 0)
                {
                    dataGridWorld.DataSource = _worldDataService.GetCountriesByName(txtFilter.Text);
                }
                else
                {
                    dataGridWorld.DataSource = _worldDataService.GetAllCountries();
                    txtFilter.PlaceholderText = _placeHolderCountry;
                }
                return;
            }

            if (radioBtnCities.Checked)
            {
                if (txtFilter.Text.Length > 0)
                {
                    dataGridWorld.DataSource = _worldDataService.GetCitiesByCountryCode(txtFilter.Text);
                }
                else
                {
                    dataGridWorld.DataSource = _worldDataService.GetAllCities();
                    txtFilter.PlaceholderText = _placeHolderCityAndLanguage;
                }
                return;
            }

            if (radioBtnCountryLanguage.Checked)
            {
                if (txtFilter.Text.Length > 0)
                {
                    dataGridWorld.DataSource = _worldDataService.GetCountryLanguagesByCountryCode(txtFilter.Text);
                }
                else
                {
                    dataGridWorld.DataSource = _worldDataService.GetAllCountryLanguages();
                    txtFilter.PlaceholderText = _placeHolderCityAndLanguage;
                }
                return;
            }
        }
    }
}
