
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MecanicaForm
{
    public partial class HomePage : Form
    {
        private System.Windows.Forms.Timer menuTimer;
        private bool isMenuOpening;
        private int targetMenuWidth = 258;
        private int menuStep = 20;

        public HomePage()
        {
            InitializeComponent();

            // Inicialize o Timer após os componentes  
            menuTimer = new System.Windows.Forms.Timer();
            menuTimer.Interval = 10;
            menuTimer.Tick += MenuTimer_Tick;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            // Garante que o menu começa fechado ao carregar o formulário  
            leftMenu.Width = 0;
            leftMenu.Visible = false;
        }

        private void openMenu_Click(object sender, EventArgs e)
        {
            if (menuTimer.Enabled) return; // Evita múltiplas animações simultâneas  

            if (leftMenu.Visible && leftMenu.Width > 0)
            {
                isMenuOpening = false;
                menuTimer.Start();
            }
            else
            {
                leftMenu.Visible = true;
                isMenuOpening = true;
                menuTimer.Start();
            }
        }

        private void closeWindowBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuTimer_Tick(object? sender, EventArgs e)
        {
            if (isMenuOpening)
            {
                if (leftMenu.Width < targetMenuWidth)
                {
                    leftMenu.Width += menuStep;
                    if (leftMenu.Width >= targetMenuWidth)
                    {
                        leftMenu.Width = targetMenuWidth;
                        menuTimer.Stop();
                    }
                }
                else
                {
                    menuTimer.Stop();
                }
            }
            else
            {
                if (leftMenu.Width > 0)
                {
                    leftMenu.Width -= menuStep;
                    if (leftMenu.Width <= 0)
                    {
                        leftMenu.Width = 0;
                        leftMenu.Visible = false;
                        menuTimer.Stop();
                    }
                }
                else
                {
                    leftMenu.Visible = false;
                    menuTimer.Stop();
                }
            }
        }
    }
}