using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CommandExample
{
    /// <summary>
    /// Interaction logic for DataTemplateExample.xaml
    /// </summary>
    public partial class DataTemplateExample : Window
    {
        public DataTemplateExample()
        {
            InitializeComponent();
                    List < Book > bookList = new List < Book > ();  
	        bookList.Add(new Book() {  
            CoverImage = "logo2.png",  
                Name = "Computer Networking",  
	                Author = "James F. Kurose"  
       });
            bookList.Add(new Book()
            {
                CoverImage = "logo2.png",
                Name = "JAVA",
                Author = "James F. Kurose"
            });
            bookList.Add(new Book()
            {
                CoverImage = "logo2.png",
                Name = "C#",
                Author = "James F. Kurose"
            });

            this.dataTemplate.ItemsSource = bookList;  
        }
    }

    class Book
    {
        public string CoverImage {  
	        get;  
	        set;  
	    }  
	    public string Name {  
	        get;  
	        set;  
	    }  
	    public string Author {  
	        get;  
	        set;  
	    }  

    }

}
