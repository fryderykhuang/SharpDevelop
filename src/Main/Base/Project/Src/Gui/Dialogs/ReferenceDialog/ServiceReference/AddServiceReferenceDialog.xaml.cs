﻿/*
 * Created by SharpDevelop.
 * User: Peter Forstmeier
 * Date: 12.10.2011
 * Time: 19:24
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

using ICSharpCode.SharpDevelop.Gui.Dialogs.ReferenceDialog.ServiceReference;

namespace ICSharpCode.SharpDevelop.Gui.Dialogs.ReferenceDialog.ServiceReference
{
	/// <summary>
	/// Interaction logic for AddServiceReferenceDialog.xaml
	/// </summary>
	public partial class AddServiceReferenceDialog : Window
	{
		public AddServiceReferenceDialog()
		{
			InitializeComponent();
		}
		
		
		void okButtonClick(object sender, RoutedEventArgs e)
		{
			this.DialogResult = true;
			Close();
		}
		
		void cancelButtonClick(object sender, RoutedEventArgs e)
		{
			this.DialogResult = false;
			Close();
		}
		
		
		void Cbo_LostFocus(object sender, RoutedEventArgs e)
		{
			var comboBox = (ComboBox) sender;
			if(comboBox.SelectedItem != null)
				return;
			var newItem = comboBox.Text;
			comboBox.SelectedItem = newItem;
		}
		
		
		void Tree_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
		{
			if (e.NewValue != null) {
				ServiceItem myItem = (ServiceItem)e.NewValue;
				var dc = (AddServiceReferenceViewModel)tree.DataContext;
				dc.ServiceItem = myItem;
			}
		}
	}
}