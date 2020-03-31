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
    /// Interaction logic for HierarchicalDataTemplate.xaml
    /// </summary>
    public partial class HierarchicalDataTemplate : Window
    {
        public HierarchicalDataTemplate()
        {
            InitializeComponent();
           var parent1 = new Parent("Parent #1") {  
    ChildItems = {  
        new Child("Child Item #1.1"),  
	        new Child("Child Item #1.2"),  
	        new Child("Child Item #1.3")  
	    }  
	};
           var parent2 = new Parent("Parent #2")
           {
               ChildItems = {  
        new Child("Child Item #2.1"),  
	        new Child("Child Item #2.2"),  
	        new Child("Child Item #2.3")  
	    }
           };  

            	this.treeView.Items.Clear();
                List < Parent > parent = new List<Parent>();
                parent.Add(parent1);
                parent.Add(parent2);
                this.treeView.ItemsSource = parent;

        }
    }
    public class Child
    {
        public String Title{get;set;}
        public Child(String Title)
        {
            this.Title = Title;
        }

    }
    public class Parent
    {
        public String Title { get; set; }
        public Parent(String Title)
        {
            this.Title = Title;
            ChildItems = new List<Child>();  
        }
        public List < Child > ChildItems {  
	        get;  
	        set;  
	    }  

    }
}
