using System;
using System.Collections.Generic;
using System.Text;

namespace App2.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {

        private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;

        public string Nombre
        {
            get => _nombre;
            set
            {
                if (string.Equals(_nombre, value)) return;
                _nombre = value;
                RaisePropertyChanged(nameof(Nombre));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string ApellidoPaterno
        {
            get => _apellidoPaterno;
            set
            {
                if (string.Equals(_apellidoPaterno, value)) return;
                _apellidoPaterno = value;
                RaisePropertyChanged(nameof(ApellidoPaterno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string ApellidoMaterno
        {
            get => _apellidoMaterno;
            set
            {
                if (string.Equals(_apellidoMaterno, value)) return;
                _apellidoMaterno = value;
                RaisePropertyChanged(nameof(ApellidoMaterno));
                RaisePropertyChanged(nameof(NombreCompleto));
            }
        }

        public string NombreCompleto
        {
            get => $"Nombre completo: {Nombre} {ApellidoPaterno} {ApellidoMaterno}";
        }

    }
}
