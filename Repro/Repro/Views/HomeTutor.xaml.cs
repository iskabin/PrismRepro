using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Repro.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomeTutor : MasterDetailPage
	{
		public HomeTutor ()
		{
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                throw ex;
            }            
        }
    }    
}