using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iznajmljivanje_Vozila.Forms
{
    public partial class FrmReservationRecipe : Form
    {
        public Reservation selectedReservation;
        public FrmReservationRecipe(Reservation reservation)
        {
            selectedReservation = reservation;
            InitializeComponent();
        }
    }
}
