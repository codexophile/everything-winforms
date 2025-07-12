namespace everything_winforms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            searchTextBox = new TextBox();
            searchButton = new Button();
            resultsListView = new ListView();
            largeImageList = new ImageList(components);
            smallImageList = new ImageList(components);
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 12);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(695, 23);
            searchTextBox.TabIndex = 0;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(713, 12);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 1;
            searchButton.Text = "button1";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // resultsListView
            // 
            resultsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            resultsListView.LargeImageList = largeImageList;
            resultsListView.Location = new Point(12, 41);
            resultsListView.Name = "resultsListView";
            resultsListView.Size = new Size(776, 159);
            resultsListView.SmallImageList = smallImageList;
            resultsListView.TabIndex = 2;
            resultsListView.UseCompatibleStateImageBehavior = false;
            resultsListView.View = View.Details;
            // 
            // largeImageList
            // 
            largeImageList.ColorDepth = ColorDepth.Depth32Bit;
            largeImageList.ImageSize = new Size(16, 16);
            largeImageList.TransparentColor = Color.Transparent;
            // 
            // smallImageList
            // 
            smallImageList.ColorDepth = ColorDepth.Depth32Bit;
            smallImageList.ImageSize = new Size(16, 16);
            smallImageList.TransparentColor = Color.Transparent;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Folder";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Size";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Date Modified";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsListView);
            Controls.Add(searchButton);
            Controls.Add(searchTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private Button searchButton;
        private ListView resultsListView;
        private ImageList smallImageList;
        private ImageList largeImageList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}