using ControllerMotorista.dao;
using ControllerMotorista.models;
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

namespace FrotaVeiculoPim.Views
{
    /// <summary>
    /// Lógica interna para Controle_Motorista.xaml
    /// </summary>
    public partial class Controle_Motorista //: UserControl
    {
        public Controle_Motorista()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnListaMotorista_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, RoutedEventArgs e)
        {
            string exameMedico;
            if (rbNao.IsChecked == true)
                exameMedico = "NAO";
            else
                exameMedico = "SIM";

            MotoristaDao mdao = new MotoristaDao();
            Motorista motorista = new Motorista()
            {
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                Cnh = txtCnh.Text,
                CategoriaCnh = txtCatCnh.Text,
                DataNascimento = dtDataNasc.SelectedDate.Value,
                ExameMedico = exameMedico,
                Email = txtEmail.Text
            };
            motorista.Endereco = new Endereco();
            motorista.Endereco.Rua = txtRua.Text;
            motorista.Endereco.Bairro = txtBairro.Text;
            motorista.Endereco.Numero = txtNumero.Text;
            motorista.Endereco.Cidade = txtCidade.Text;
            motorista.Endereco.Cep = txtCep.Text;

            if(verificarCamposNulos())
                MessageBox.Show("Ainda ha campos para serem preenchidos!!", "Alerta!", MessageBoxButton.OK);
            else
            {
                mdao.InserirMotorista(motorista);
                MessageBox.Show("Motorista inserido com sucesso!!");
            }

        }

        private bool verificarCamposNulos()
        {
            if (txtNome.Text == "" || txtCpf.Text == "" || txtCnh.Text == "" || txtCatCnh.Text == "" || rbNao.IsChecked == false || rbSim.IsChecked == false
                || txtRua.Text == "" || txtBairro.Text == "" || txtNumero.Text == "" || txtCidade.Text == "" || txtEmail.Text == "" || txtCep.Text == "")
                return true;
            else
                return false;
        }
    }
}
