using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisDemo
{
    public partial class MyListView : ListView
    {
        public MyListView()
        {
            InitializeComponent();
            this.View = View.Details;
            this.FullRowSelect = true;
            this.DoubleBuffered = true;
        }
        private bool mCreating;
        private bool mReadOnly;
        protected override void OnHandleCreated(EventArgs e)
        {
            mCreating = true;
            base.OnHandleCreated(e);
            mCreating = false;
        }
        public bool ReadOnly
        {
            get { return mReadOnly; }
            set { mReadOnly = value; }
        }
        protected override void OnItemCheck(ItemCheckEventArgs e)
        {
            if (!mCreating && mReadOnly) e.NewValue = e.CurrentValue;
            base.OnItemCheck(e);
        }
    }
    
}
