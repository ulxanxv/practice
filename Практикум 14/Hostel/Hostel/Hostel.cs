﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel {
    public partial class Hostel : Form {
        public Hostel() {
            InitializeComponent();

            exitButton.Click += ExitButton_Click;

            studentsButton.Click += StudentsButton_Click;
            roomsButton.Click += RoomsButton_Click;
            privilegesButton.Click += PrivilegesButton_Click;
        }

        private void PrivilegesButton_Click(object sender, EventArgs e) {
            new Privileges().ShowDialog();
        }

        private void RoomsButton_Click(object sender, EventArgs e) {
            new Rooms().ShowDialog();
        }

        private void StudentsButton_Click(object sender, EventArgs e) {
            new Students().ShowDialog();
        }

        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
