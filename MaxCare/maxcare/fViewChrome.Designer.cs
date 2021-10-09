namespace maxcare
{
	// Token: 0x020000A0 RID: 160
	public partial class fViewChrome : global::System.Windows.Forms.Form
	{
		// Token: 0x06000612 RID: 1554 RVA: 0x0008CB48 File Offset: 0x0008AD48
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0008CBA8 File Offset: 0x0008ADA8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::maxcare.fViewChrome));
			this.panelListDevice = new global::System.Windows.Forms.FlowLayoutPanel();
			base.SuspendLayout();
			this.panelListDevice.AutoScroll = true;
			this.panelListDevice.BackColor = global::System.Drawing.Color.White;
			this.panelListDevice.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.panelListDevice.Location = new global::System.Drawing.Point(0, 0);
			this.panelListDevice.Name = "panelListDevice";
			this.panelListDevice.Padding = new global::System.Windows.Forms.Padding(10);
			this.panelListDevice.Size = new global::System.Drawing.Size(933, 554);
			this.panelListDevice.TabIndex = 1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(7f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(933, 554);
			base.Controls.Add(this.panelListDevice);
			this.Font = new global::System.Drawing.Font("Tahoma", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			base.Margin = new global::System.Windows.Forms.Padding(3, 4, 3, 4);
			base.Name = "fInterfaceChrome";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giao diện Chrome";
			base.WindowState = global::System.Windows.Forms.FormWindowState.Maximized;
			base.ResumeLayout(false);
		}

		// Token: 0x0400059B RID: 1435
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400059C RID: 1436
		private global::System.Windows.Forms.FlowLayoutPanel panelListDevice;
	}
}
