using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonPorts;
using MusicPorts;
using ExplicitArchitecture.TuneSearchExample.MockCore;
using Xamarin.Forms;

namespace TuneSearchAssignment1
{
    public partial class MainPage : ContentPage
    {
        private IService<ISearchTerm, List<ICollectionEntity>> _service = new MockSearchTracksService();

        public MainPage()
        {
            InitializeComponent();                        
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await _service.Execute(new SearchTermDTO { Term = "Term" }, SuccessHandler, ErrorHandler);
        }

        private void ErrorHandler(Exception obj)
        {
            //throw new NotImplementedException();
        }

        private void SuccessHandler(List<ICollectionEntity> obj)
        {
            Debug.WriteLine(obj.ToString());
            //throw new NotImplementedException();
        }
    }
}
