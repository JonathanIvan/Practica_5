
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	private global::Gtk.Label lblNum2;
	private global::Gtk.Label lblResultado;
	private global::Gtk.Entry txtNum1;
	private global::Gtk.Entry txtNum2;
	private global::Gtk.Entry txtResultado;
	private global::Gtk.Button btnResta;
	private global::Gtk.Label lblNum1;
	private global::Gtk.Button btnSuma;
	private global::Gtk.Button btnDividir;
	private global::Gtk.Button btnMultiplica;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblNum2 = new global::Gtk.Label ();
		this.lblNum2.Name = "lblNum2";
		this.lblNum2.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 2");
		this.fixed1.Add (this.lblNum2);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblNum2]));
		w1.X = 45;
		w1.Y = 81;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblResultado = new global::Gtk.Label ();
		this.lblResultado.Name = "lblResultado";
		this.lblResultado.LabelProp = global::Mono.Unix.Catalog.GetString ("Resultado");
		this.fixed1.Add (this.lblResultado);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblResultado]));
		w2.X = 45;
		w2.Y = 112;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtNum1 = new global::Gtk.Entry ();
		this.txtNum1.CanFocus = true;
		this.txtNum1.Name = "txtNum1";
		this.txtNum1.IsEditable = true;
		this.txtNum1.InvisibleChar = '●';
		this.fixed1.Add (this.txtNum1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtNum1]));
		w3.X = 118;
		w3.Y = 42;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtNum2 = new global::Gtk.Entry ();
		this.txtNum2.CanFocus = true;
		this.txtNum2.Name = "txtNum2";
		this.txtNum2.IsEditable = true;
		this.txtNum2.InvisibleChar = '●';
		this.fixed1.Add (this.txtNum2);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtNum2]));
		w4.X = 119;
		w4.Y = 75;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.txtResultado = new global::Gtk.Entry ();
		this.txtResultado.CanFocus = true;
		this.txtResultado.Name = "txtResultado";
		this.txtResultado.IsEditable = true;
		this.txtResultado.InvisibleChar = '●';
		this.fixed1.Add (this.txtResultado);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.txtResultado]));
		w5.X = 119;
		w5.Y = 110;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnResta = new global::Gtk.Button ();
		this.btnResta.CanFocus = true;
		this.btnResta.Name = "btnResta";
		this.btnResta.UseUnderline = true;
		this.btnResta.Label = global::Mono.Unix.Catalog.GetString ("Resta");
		this.fixed1.Add (this.btnResta);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnResta]));
		w6.X = 104;
		w6.Y = 206;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.lblNum1 = new global::Gtk.Label ();
		this.lblNum1.Name = "lblNum1";
		this.lblNum1.LabelProp = global::Mono.Unix.Catalog.GetString ("Numero 1");
		this.fixed1.Add (this.lblNum1);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.lblNum1]));
		w7.X = 48;
		w7.Y = 46;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnSuma = new global::Gtk.Button ();
		this.btnSuma.CanFocus = true;
		this.btnSuma.Name = "btnSuma";
		this.btnSuma.UseUnderline = true;
		this.btnSuma.Label = global::Mono.Unix.Catalog.GetString ("Suma");
		this.fixed1.Add (this.btnSuma);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnSuma]));
		w8.X = 35;
		w8.Y = 205;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnDividir = new global::Gtk.Button ();
		this.btnDividir.CanFocus = true;
		this.btnDividir.Name = "btnDividir";
		this.btnDividir.UseUnderline = true;
		this.btnDividir.Label = global::Mono.Unix.Catalog.GetString ("Dividir");
		this.fixed1.Add (this.btnDividir);
		global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnDividir]));
		w9.X = 263;
		w9.Y = 206;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.btnMultiplica = new global::Gtk.Button ();
		this.btnMultiplica.CanFocus = true;
		this.btnMultiplica.Name = "btnMultiplica";
		this.btnMultiplica.UseUnderline = true;
		this.btnMultiplica.Label = global::Mono.Unix.Catalog.GetString ("Multiplicar");
		this.fixed1.Add (this.btnMultiplica);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.btnMultiplica]));
		w10.X = 167;
		w10.Y = 205;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.btnResta.Clicked += new global::System.EventHandler (this.OnBtnRestaClicked);
		this.btnSuma.Clicked += new global::System.EventHandler (this.OnBtnSumaClicked);
		this.btnDividir.Clicked += new global::System.EventHandler (this.OnBtnDividirClicked);
		this.btnMultiplica.Clicked += new global::System.EventHandler (this.OnBtnMultiplicaClicked);
	}
}