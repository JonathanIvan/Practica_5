using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBtnSumaClicked (object sender, EventArgs e)
	{
		int Num1=int.Parse(this.txtNum1.Text);
		int Num2=int.Parse(this.txtNum2.Text);
		int res=Num1+Num2;
		this.txtResultado.Text=res.ToString();
	}

	protected void OnBtnRestaClicked (object sender, EventArgs e)
	{
		int Num1=int.Parse(this.txtNum1.Text);
		int Num2=int.Parse(this.txtNum2.Text);
		int res=Num1-Num2;
		this.txtResultado.Text=res.ToString();
	}

	protected void OnBtnMultiplicaClicked (object sender, EventArgs e)
	{
		int Num1=int.Parse(this.txtNum1.Text);
		int Num2=int.Parse(this.txtNum2.Text);
		int res=Num1*Num2;
		this.txtResultado.Text=res.ToString();
	}

	protected void OnBtnDividirClicked (object sender, EventArgs e)
	{
		int Num1=int.Parse(this.txtNum1.Text);
		int Num2=int.Parse(this.txtNum2.Text);
		int res=Num1/Num2;
		this.txtResultado.Text=res.ToString();
	}
}
