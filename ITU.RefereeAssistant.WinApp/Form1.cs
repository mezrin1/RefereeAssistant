using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using System.IO;
using System.Reflection;

using ITU.RefereeAssistant.Domain.Models;
using ITU.RefereeAssistant.BL;
using ITU.RefereeAssistant.Domain;


namespace ITU.RefereeAssistant.WinApp
{
    public partial class FormReferee : Form
    {
        /// <summary>
        /// Коллекция имен игроков
        /// </summary>
        public List<string> PlayerNames { get; set; }
        /// <summary>
        /// Коллекция типов систем
        /// </summary>
        public List<ITournamentType> tourTypes { get; set; } 


        public FormReferee()
        {
            InitializeComponent();
            PlayerNames = new List<string>();
            tourTypes = new List<ITournamentType>();
            AddTypes();
        }

        static List<ITournamentType> GetTypes()
        {
            var result = new List<ITournamentType>(); // экземпляр интерфейса

            var currentDirectory = Environment.CurrentDirectory;
            var dlls = Directory.GetFiles(currentDirectory, "*.dll");

            foreach (var dll in dlls)
            {

                var assembly = Assembly.LoadFile(dll);
                var types = assembly.GetTypes();

                foreach (var type in types)
                {
                    // проверить что этот класс является системой турнира
                    // для это нужно понять какие интерфейсы он реализует
                    var interfaces = type.GetInterfaces();
                    // если класс реализует ITournamentType
                    if (interfaces.Any(inter => inter.Name == "ITournamentType"))
                    {
                        // то нужно создать экземпляр класса
                        //as - если приведение типов не удалось выводит null
                        var tournamentType = Activator.CreateInstance(type) as ITournamentType;
                        // и добавить его в результативный список
                        if (tournamentType != null)
                        {
                            result.Add(tournamentType);
                        }
                    }
                }
            }
            return result;
        }

        private void AddTypes()
        {
            tourTypes = GetTypes(); // Получение типов из dll

            // Добавление в cbTourType списка типов систем
            for (int i = 0; i < tourTypes.Count; i++)
            {
                cbTourType.Items.Add(tourTypes[i].Name);
            }
        }

        /// <summary>
        /// Добавление имени игрока из поля tbPlayerName 
        /// в список участников gbPlayers
        /// </summary>
        /*private void AddPlayer()
        {
            var height = 20;
            var step = gbPlayers.Controls.Count;
            //private System.Windows.Forms.Label label2;

            PlayerNames.Add(tbPlayerName.Text);

            var label = new Label
            {
                AutoSize = true,
                Location = new Point(19, height * step + 27),
                Name = "label",
                Size = new Size(80, 13),
                TabIndex = 10,
                BackColor = Color.White,
                Text = tbPlayerName.Text,
            };

            tbPlayerName.Text = "";

            this.gbPlayers.Controls.Add(label);
        }*/

        private void AddPlayer()
        {
            PlayerNames.Add(tbPlayerName.Text);

            var label = new Label
            {
                AutoSize = true,
                Name = "label",
                TabIndex = 10,
                BackColor = Color.White,
                Text = tbPlayerName.Text,
            };

            tbPlayerName.Text = "";

            var button = new Button
            {
                Name = "button",
                Size = new System.Drawing.Size(25, 25),
                TabIndex = 5,
                Text = "X",
                ForeColor = Color.Red,
                UseVisualStyleBackColor = true,
                Tag = label,
            };

            button.Click += new System.EventHandler(btnRemove_Click);

            tableLayoutPanel1.Controls.Add(label);
            tableLayoutPanel1.Controls.Add(button);

            label3.Text += $"Список участников: {PlayerNames.Count}";
        }


        /// <summary>
        /// Добавление имени по нажатию на кнопку btnAdd
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddPlayer();
        }


        /// <summary>
        /// Добавление имени по нажатию на Enter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gbPlayerName_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                AddPlayer();
            }
        }


        /// <summary>
        /// Удаление участников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
           /* var button = sender as Button;
            if (button == null)
            {
                return;
            }

            var label = button.Tag as Label;

            if (label != null)
            {
                PlayerNames.Remove(label.Text);
                label.Dispose();
            }

            button.Dispose();

            gbPlayers.Text = $"Список участников {PlayerNames.Count}";
            */
        }


        /// <summary>
        /// Запуск турнира
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            var ts = new TournamentService();

            if(cbTourType.SelectedIndex == -1)
            {
                MessageBox.Show("Не выбран тип системы!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            label2.Text = Convert.ToString(cbTourType.SelectedIndex);

            //PlayerNames.Add(tbPlayerName.Text);
            //var tour = ts.Create(new Raiting[] {
            //    new Raiting(new Player() {Name = "q1"}),
            //    new Raiting(new Player() {Name = "q2"}),
            //    new Raiting(new Player() {Name = "q3"}),
            //    new Raiting(new Player() {Name = "q4"}),
            //}, tourTypes[numberType - 1]);

            if(PlayerNames.Count == 0)
            {
                MessageBox.Show("Не добавлены участники!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                return;
            }

            var raitings = PlayerNames.Select(
                name => new Raiting(new Player() { Name = name })
                );


            //tourTypes[cbTourType.SelectedIndex]
            /*switch(cbTourType.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
            }*/

              var tour = ts.Create(raitings.ToArray(), tourTypes[cbTourType.SelectedIndex]);

              var round = ts.GenerateRound(tour);

              label2.Text = "";
              foreach (var item in round.Matches)
              {
                  label2.Text += $"{item}\r\n";
              }
              
              //gbPlayers.Controls.

        }
    }
}
