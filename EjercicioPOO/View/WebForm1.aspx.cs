using EjercicioPOO.Model;
using EjercicioPOO.Repository;
using EjercicioPOO.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EjercicioPOO.View
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String NumeroCuenta, Nombre;
            Double SaldoInicial, TasaInteres;
            NumeroCuenta = this.txtNumeroCuenta.Text;
            Nombre = this.txtNombre.Text;
            SaldoInicial = Convert.ToDouble(this.txtSaldo.Text);
            TasaInteres = Convert.ToDouble(this.txtInteres.Text);
            if (SaldoInicial<1)
            {
                this.lblInformacion.CssClass = "text-danger";
                this.lblInformacion.Text = "El saldo es menor al minimo para abrir la cuenta";
                return;
            }
            Cuenta oCuenta = new Cuenta
            {
                NumeroCuenta = NumeroCuenta,
                Saldo = SaldoInicial,
                Interes = TasaInteres,
                Nombre = Nombre,
                Transacciones = new List<Transacciones>()
            };
            Singleton.Instance.cuenta = oCuenta;
            this.lblInformacion.CssClass = "text-success";
            this.lblInformacion.Text = "La cuenta fue creada exitosamente";
        }

        protected void btnAccion_Click(object sender, EventArgs e)
        {
            ICuenta cuenta = new RCuenta();
            int index = this.dropAccion.SelectedIndex;
            double monto = Convert.ToDouble(this.txtMonto.Text);
            if (monto<=0)
            {
                this.lblInformacionRetiroDeposito.CssClass = "text-danger";
                this.lblInformacionRetiroDeposito.Text = "Monto invalido";
                return;
            }
            if (index==0)
            {
                Response response = cuenta.Retirar(monto);
                if (response.IsSuccess)
                {
                    this.lblInformacionRetiroDeposito.CssClass = "text-success";
                    this.lblInformacionRetiroDeposito.Text = "El retiro se realizo de manera satisfactoria";
                }
                else
                {
                    this.lblInformacionRetiroDeposito.CssClass = "text-danger";
                    this.lblInformacionRetiroDeposito.Text = response.Message;
                }
            }
            else
            {
                Response response = cuenta.Depositar(monto);
                if (response.IsSuccess)
                {
                    this.lblInformacionRetiroDeposito.CssClass = "text-success";
                    this.lblInformacionRetiroDeposito.Text = "El deposito se realizo de manera satisfactoria";
                }
                else
                {
                    this.lblInformacionRetiroDeposito.CssClass = "text-danger";
                    this.lblInformacionRetiroDeposito.Text = response.Message;
                }
            }
            LoadData();
        }
        private void LoadData()
        {
            ICuenta cuenta = new RCuenta();
            Response response;
            response = cuenta.GetSaldo();
            if (response.IsSuccess)
            {
                this.txtSaldo.Text = response.Result.ToString();
            }
            response = cuenta.GetHistorial();
            if (response.IsSuccess)
            {
                this.grdTransacciones.DataSource = response.Result;
                this.grdTransacciones.DataBind();
            }
        }

        protected void btnRealizarProyeccion_Click(object sender, EventArgs e)
        {
            ICuenta oCuenta = new RCuenta();
            int years = Convert.ToInt32(this.txtTiempo.Text);
            var response = oCuenta.Proyeccion(years);
            if (response.IsSuccess)
            {
                this.lblInformacionProyeccion.CssClass = "text-success";
                this.lblInformacionProyeccion.Text = response.Message;
            }
            else
            {
                this.lblInformacionProyeccion.CssClass = "text-danger";
                this.lblInformacionProyeccion.Text = response.Message;
            }
        }
    }
}