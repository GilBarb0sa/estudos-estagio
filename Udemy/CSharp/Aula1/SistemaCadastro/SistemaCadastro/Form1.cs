﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaCadastro
{
    public partial class Form1 : Form
    {
        List<Pessoa> pessoas; //enraiza a classe metodo para poder utilizar uma lista
        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa>();
           
            comboEC.Items.Add("Solteiro(a)");
            comboEC.Items.Add("Casado(a)");
            comboEC.Items.Add("Divorciado(a)");
            comboEC.Items.Add("Viuvo(a)");

            comboEC.SelectedIndex = 0; // inicia com o campo solteiro selecionado, como default

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, System.EventArgs e)
        {
            int index = -1;

            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == txtNome.Text)
                {
                    index = pessoas.IndexOf(pessoa); // Estamos atribuindo ao index o valor do indice do cadastro na lista de pessoas
                }
            }

            if (txtNome.Text == "")
            {
                MessageBox.Show("Preencha o campo nome.");
                txtNome.Focus(); 
                return;
            }

            if (txtTelefone.Text == "")
            {
                MessageBox.Show("Preencha o campo telefone.");
                txtTelefone.Focus();
                return;
            }

            char sexo;

            if (radioM.Checked)
            {
                sexo = 'M';
            }
            else if (radioF.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }
           
            Pessoa p = new Pessoa();
            p.Nome = txtNome.Text;
            p.DataNascimento = txtData.Text;
            p.EstadoCivil = comboEC.SelectedItem.ToString();
            p.Telefone = txtTelefone.Text;
            p.CasaPropria = checkCasa.Checked;
            p.Veiculo = checkVeiculo.Checked;
            p.Sexo = sexo;

            if (index < 0)
            {
                pessoas.Add(p);
            } 
            else
            {
                pessoas[index] = p;
            }

            btnLimpar_Click(btnLimpar, EventArgs.Empty);

            Listar();
        }

        private void btnExcluir_Click(object sender, System.EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, System.EventArgs e)
        {

        }

        private void Listar()
        {
            lista.Items.Clear();

            foreach (Pessoa p in pessoas)
            {
                lista.Items.Add(p.Nome);
            }
        }
    }
}
