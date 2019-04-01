using SQLiteXF.Core.Configuracoes;
using SQLiteXF.Model.Data.Financeiro;
using SQLiteXF.Repository.Financeiro;
using SQLiteXF.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace SQLiteXF.ViewModels
{
    public class DespesaViewModel : ViewModelBase
    {
        #region Private Properties

        private DespesaRepository despesaRepository = new DespesaRepository(ApplicationSettings.DbPath);
        private List<Despesa> _despesas;

        #endregion Private Properties

        #region Public Properties

        public List<Despesa> Despesas
        {
            get => _despesas;
            set
            {
                _despesas = value;
                OnPropertyChanged();
            }
        }

        public string Descricao { get; set; }
        public decimal Valor { get; set; }


        public ICommand RefreshCommand
        {
            get
            {
                return new Command(() =>
                {
                    Refresh();
                });
            }
        }


        public ICommand AddCommand
        {
            get
            {
                return new Command(() =>
                {
                    Save();
                });
            }
        }

        #endregion  Public Properties

        #region Private Methods
        
        //Podendo se usar um DTO para determinadas propriedades de exibição por exemplo
        public void Refresh()
        {
            Despesas = despesaRepository.Select();
        }

        //Podendo se usar um DTO e convertendo par ao objeto
        private void Save()
        {
            var despesa = new Despesa
            {
                Descricao = Descricao,
                Valor = Valor,
                Pago = 1,
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now
            };

            despesaRepository.Save(despesa);
            Refresh();
        }

        #endregion Private Methods
    }
}
