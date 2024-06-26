﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LearnJsonEverything.LessonEditor.Controls
{
	/// <summary>
	/// Interaction logic for TextInput.xaml
	/// </summary>
	public partial class TextInput : UserControl
	{
		public TextInput()
		{
			InitializeComponent();
		}

		public string Label
		{
			get => (string)GetValue(LabelProperty);
			set => SetValue(LabelProperty, value);
		}

		public static readonly DependencyProperty LabelProperty =
			DependencyProperty.Register(nameof(Label), typeof(string), typeof(TextInput), new PropertyMetadata(string.Empty));

		public string TextContent
		{
			get => (string)GetValue(TextContentProperty);
			set => SetValue(TextContentProperty, value);
		}

		public static readonly DependencyProperty TextContentProperty =
			DependencyProperty.Register(nameof(TextContent), typeof(string), typeof(TextInput), new PropertyMetadata(string.Empty));


	}
}
