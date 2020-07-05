﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototypeCSharp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            AssemblyName thisAssemName = this.GetType().Assembly.GetName();

            if (Configurations.environment == "PRODUCTION")
            {
                this.Text = thisAssemName.Name + " Version " + thisAssemName.Version;
            }
            else
            {
                this.Text = thisAssemName.Name + " Version " + thisAssemName.Version + " " + Configurations.environment;
            }
        }
    }
}
