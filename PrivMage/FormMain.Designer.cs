using PrivMage;

namespace PrivMage
{
    partial class FormMain
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
            tabControlMain = new ArrowlessTabControl();
            tabPageSelect = new TabPage();
            splitContainerSelect = new SplitContainer();
            listViewSelect = new ListView();
            tableLayoutPanelSelectInfo = new TableLayoutPanel();
            pictureBoxSelectPreview = new PictureBox();
            tableLayoutPanelSelectInfoLabels = new TableLayoutPanel();
            labelSelectInfoName = new Label();
            labelSelectInfoDate = new Label();
            labelSelectInfoTags = new Label();
            buttonSelectRead = new Button();
            labelSelectInfoID = new Label();
            tabPageView = new TabPage();
            tableLayoutPanelView = new TableLayoutPanel();
            tableLayoutPanelViewControll = new TableLayoutPanel();
            buttonViewPrevious = new Button();
            buttonViewNext = new Button();
            flowLayoutPanelViewControll = new FlowLayoutPanel();
            textBoxViewCurrentImage = new TextBox();
            labelViewMaxImages = new Label();
            checkBoxViewOrignianResolution = new CheckBox();
            pictureBoxView = new PictureBox();
            tabPageEdit = new TabPage();
            tabControlEdit = new ArrowlessTabControl();
            tabPageEditNew = new TabPage();
            tableLayoutPanelEditNew = new TableLayoutPanel();
            labelEditNewTitle = new Label();
            labelEditNewCover = new Label();
            textBoxEditNewTitle = new TextBox();
            textBoxEditNewCoverPath = new TextBox();
            buttonEditNewCover = new Button();
            listViewEditNewImages = new ListView();
            columnHeaderModifyNew = new ColumnHeader();
            buttonEditNewCreate = new Button();
            buttonEditNewRemoveImage = new Button();
            tableLayoutPanelEditNewLeftControll = new TableLayoutPanel();
            buttonEditNewAddImage = new Button();
            textBoxEditNewTags = new TextBox();
            labelEditNewTags = new Label();
            tabPageEditExport = new TabPage();
            tableLayoutPanelEditExport = new TableLayoutPanel();
            buttonEditExport = new Button();
            listViewEditExport = new ListView();
            columnHeaderName = new ColumnHeader();
            tabPageModify = new TabPage();
            tableLayoutPanelEditModify = new TableLayoutPanel();
            tableLayoutPanelEditModifyControll = new TableLayoutPanel();
            buttonEditModifyAttach = new Button();
            buttonEditModifyRemove = new Button();
            buttonEditModifyInsert = new Button();
            buttonEditModifySelect = new Button();
            buttonEditModifyConfirm = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonEditModifySwitchPlaces = new Button();
            textBox1 = new TextBox();
            listViewEditModify = new ListView();
            columnHeaderModifyName = new ColumnHeader();
            imageList1 = new ImageList(components);
            tabControlMain.SuspendLayout();
            tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerSelect).BeginInit();
            splitContainerSelect.Panel1.SuspendLayout();
            splitContainerSelect.Panel2.SuspendLayout();
            splitContainerSelect.SuspendLayout();
            tableLayoutPanelSelectInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectPreview).BeginInit();
            tableLayoutPanelSelectInfoLabels.SuspendLayout();
            tabPageView.SuspendLayout();
            tableLayoutPanelView.SuspendLayout();
            tableLayoutPanelViewControll.SuspendLayout();
            flowLayoutPanelViewControll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxView).BeginInit();
            tabPageEdit.SuspendLayout();
            tabControlEdit.SuspendLayout();
            tabPageEditNew.SuspendLayout();
            tableLayoutPanelEditNew.SuspendLayout();
            tableLayoutPanelEditNewLeftControll.SuspendLayout();
            tabPageEditExport.SuspendLayout();
            tableLayoutPanelEditExport.SuspendLayout();
            tabPageModify.SuspendLayout();
            tableLayoutPanelEditModify.SuspendLayout();
            tableLayoutPanelEditModifyControll.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageSelect);
            tabControlMain.Controls.Add(tabPageView);
            tabControlMain.Controls.Add(tabPageEdit);
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(1778, 1144);
            tabControlMain.TabIndex = 0;
            tabControlMain.TabStop = false;
            // 
            // tabPageSelect
            // 
            tabPageSelect.Controls.Add(splitContainerSelect);
            tabPageSelect.Location = new Point(4, 37);
            tabPageSelect.Name = "tabPageSelect";
            tabPageSelect.Padding = new Padding(3);
            tabPageSelect.Size = new Size(1770, 1103);
            tabPageSelect.TabIndex = 0;
            tabPageSelect.Text = "Select";
            tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // splitContainerSelect
            // 
            splitContainerSelect.Dock = DockStyle.Fill;
            splitContainerSelect.Location = new Point(3, 3);
            splitContainerSelect.Name = "splitContainerSelect";
            // 
            // splitContainerSelect.Panel1
            // 
            splitContainerSelect.Panel1.Controls.Add(listViewSelect);
            splitContainerSelect.Panel1MinSize = 900;
            // 
            // splitContainerSelect.Panel2
            // 
            splitContainerSelect.Panel2.Controls.Add(tableLayoutPanelSelectInfo);
            splitContainerSelect.Panel2MinSize = 800;
            splitContainerSelect.Size = new Size(1764, 1097);
            splitContainerSelect.SplitterDistance = 947;
            splitContainerSelect.SplitterWidth = 10;
            splitContainerSelect.TabIndex = 0;
            // 
            // listViewSelect
            // 
            listViewSelect.Dock = DockStyle.Fill;
            listViewSelect.Location = new Point(0, 0);
            listViewSelect.Margin = new Padding(3, 30, 3, 3);
            listViewSelect.MultiSelect = false;
            listViewSelect.Name = "listViewSelect";
            listViewSelect.Size = new Size(947, 1097);
            listViewSelect.Sorting = SortOrder.Ascending;
            listViewSelect.TabIndex = 2;
            listViewSelect.UseCompatibleStateImageBehavior = false;
            // 
            // tableLayoutPanelSelectInfo
            // 
            tableLayoutPanelSelectInfo.ColumnCount = 1;
            tableLayoutPanelSelectInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelectInfo.Controls.Add(pictureBoxSelectPreview, 0, 0);
            tableLayoutPanelSelectInfo.Controls.Add(tableLayoutPanelSelectInfoLabels, 0, 1);
            tableLayoutPanelSelectInfo.Dock = DockStyle.Fill;
            tableLayoutPanelSelectInfo.Location = new Point(0, 0);
            tableLayoutPanelSelectInfo.Name = "tableLayoutPanelSelectInfo";
            tableLayoutPanelSelectInfo.RowCount = 2;
            tableLayoutPanelSelectInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelectInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            tableLayoutPanelSelectInfo.Size = new Size(807, 1097);
            tableLayoutPanelSelectInfo.TabIndex = 3;
            // 
            // pictureBoxSelectPreview
            // 
            pictureBoxSelectPreview.Dock = DockStyle.Fill;
            pictureBoxSelectPreview.Location = new Point(3, 3);
            pictureBoxSelectPreview.Name = "pictureBoxSelectPreview";
            pictureBoxSelectPreview.Size = new Size(801, 791);
            pictureBoxSelectPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxSelectPreview.TabIndex = 0;
            pictureBoxSelectPreview.TabStop = false;
            // 
            // tableLayoutPanelSelectInfoLabels
            // 
            tableLayoutPanelSelectInfoLabels.ColumnCount = 1;
            tableLayoutPanelSelectInfoLabels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelectInfoLabels.Controls.Add(labelSelectInfoName, 0, 0);
            tableLayoutPanelSelectInfoLabels.Controls.Add(labelSelectInfoDate, 0, 1);
            tableLayoutPanelSelectInfoLabels.Controls.Add(labelSelectInfoTags, 0, 2);
            tableLayoutPanelSelectInfoLabels.Controls.Add(buttonSelectRead, 0, 4);
            tableLayoutPanelSelectInfoLabels.Controls.Add(labelSelectInfoID, 0, 3);
            tableLayoutPanelSelectInfoLabels.Dock = DockStyle.Fill;
            tableLayoutPanelSelectInfoLabels.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanelSelectInfoLabels.Location = new Point(3, 800);
            tableLayoutPanelSelectInfoLabels.Name = "tableLayoutPanelSelectInfoLabels";
            tableLayoutPanelSelectInfoLabels.RowCount = 5;
            tableLayoutPanelSelectInfoLabels.RowStyles.Add(new RowStyle());
            tableLayoutPanelSelectInfoLabels.RowStyles.Add(new RowStyle());
            tableLayoutPanelSelectInfoLabels.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelSelectInfoLabels.RowStyles.Add(new RowStyle());
            tableLayoutPanelSelectInfoLabels.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelSelectInfoLabels.Size = new Size(801, 294);
            tableLayoutPanelSelectInfoLabels.TabIndex = 1;
            // 
            // labelSelectInfoName
            // 
            labelSelectInfoName.AutoSize = true;
            labelSelectInfoName.Dock = DockStyle.Fill;
            labelSelectInfoName.Location = new Point(6, 10);
            labelSelectInfoName.Margin = new Padding(6, 10, 6, 10);
            labelSelectInfoName.Name = "labelSelectInfoName";
            labelSelectInfoName.Size = new Size(789, 28);
            labelSelectInfoName.TabIndex = 0;
            labelSelectInfoName.Text = "Title:";
            // 
            // labelSelectInfoDate
            // 
            labelSelectInfoDate.AutoSize = true;
            labelSelectInfoDate.Dock = DockStyle.Fill;
            labelSelectInfoDate.Location = new Point(6, 58);
            labelSelectInfoDate.Margin = new Padding(6, 10, 6, 10);
            labelSelectInfoDate.Name = "labelSelectInfoDate";
            labelSelectInfoDate.Size = new Size(789, 28);
            labelSelectInfoDate.TabIndex = 1;
            labelSelectInfoDate.Text = "Created:";
            // 
            // labelSelectInfoTags
            // 
            labelSelectInfoTags.AutoSize = true;
            labelSelectInfoTags.Dock = DockStyle.Fill;
            labelSelectInfoTags.Location = new Point(6, 102);
            labelSelectInfoTags.Margin = new Padding(6);
            labelSelectInfoTags.Name = "labelSelectInfoTags";
            labelSelectInfoTags.Size = new Size(789, 88);
            labelSelectInfoTags.TabIndex = 2;
            labelSelectInfoTags.Text = "Tags:";
            // 
            // buttonSelectRead
            // 
            buttonSelectRead.Dock = DockStyle.Fill;
            buttonSelectRead.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSelectRead.Location = new Point(9, 248);
            buttonSelectRead.Margin = new Padding(9, 4, 9, 4);
            buttonSelectRead.Name = "buttonSelectRead";
            buttonSelectRead.Size = new Size(783, 42);
            buttonSelectRead.TabIndex = 0;
            buttonSelectRead.Text = "Read";
            buttonSelectRead.UseVisualStyleBackColor = true;
            buttonSelectRead.Click += buttonSelectRead_Click;
            // 
            // labelSelectInfoID
            // 
            labelSelectInfoID.AutoSize = true;
            labelSelectInfoID.Dock = DockStyle.Fill;
            labelSelectInfoID.Location = new Point(6, 206);
            labelSelectInfoID.Margin = new Padding(6, 10, 6, 10);
            labelSelectInfoID.Name = "labelSelectInfoID";
            labelSelectInfoID.Size = new Size(789, 28);
            labelSelectInfoID.TabIndex = 3;
            labelSelectInfoID.Text = "ID:";
            // 
            // tabPageView
            // 
            tabPageView.Controls.Add(tableLayoutPanelView);
            tabPageView.Location = new Point(4, 34);
            tabPageView.Name = "tabPageView";
            tabPageView.Padding = new Padding(3);
            tabPageView.Size = new Size(1770, 1106);
            tabPageView.TabIndex = 1;
            tabPageView.Text = "View";
            tabPageView.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelView
            // 
            tableLayoutPanelView.BackColor = Color.FromArgb(48, 48, 48);
            tableLayoutPanelView.ColumnCount = 1;
            tableLayoutPanelView.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelView.Controls.Add(tableLayoutPanelViewControll, 0, 1);
            tableLayoutPanelView.Controls.Add(pictureBoxView, 0, 0);
            tableLayoutPanelView.Dock = DockStyle.Fill;
            tableLayoutPanelView.Location = new Point(3, 3);
            tableLayoutPanelView.Name = "tableLayoutPanelView";
            tableLayoutPanelView.RowCount = 2;
            tableLayoutPanelView.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelView.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanelView.Size = new Size(1764, 1100);
            tableLayoutPanelView.TabIndex = 1;
            // 
            // tableLayoutPanelViewControll
            // 
            tableLayoutPanelViewControll.BackColor = Color.White;
            tableLayoutPanelViewControll.ColumnCount = 5;
            tableLayoutPanelViewControll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelViewControll.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelViewControll.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelViewControll.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelViewControll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelViewControll.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanelViewControll.Controls.Add(buttonViewPrevious, 1, 0);
            tableLayoutPanelViewControll.Controls.Add(buttonViewNext, 3, 0);
            tableLayoutPanelViewControll.Controls.Add(flowLayoutPanelViewControll, 2, 0);
            tableLayoutPanelViewControll.Controls.Add(checkBoxViewOrignianResolution, 4, 0);
            tableLayoutPanelViewControll.Dock = DockStyle.Fill;
            tableLayoutPanelViewControll.Font = new Font("Segoe UI", 12F);
            tableLayoutPanelViewControll.Location = new Point(0, 1050);
            tableLayoutPanelViewControll.Margin = new Padding(0);
            tableLayoutPanelViewControll.Name = "tableLayoutPanelViewControll";
            tableLayoutPanelViewControll.RowCount = 1;
            tableLayoutPanelViewControll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelViewControll.Size = new Size(1764, 50);
            tableLayoutPanelViewControll.TabIndex = 1;
            // 
            // buttonViewPrevious
            // 
            buttonViewPrevious.AutoSize = true;
            buttonViewPrevious.Dock = DockStyle.Fill;
            buttonViewPrevious.Enabled = false;
            buttonViewPrevious.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewPrevious.Location = new Point(710, 3);
            buttonViewPrevious.MinimumSize = new Size(100, 40);
            buttonViewPrevious.Name = "buttonViewPrevious";
            buttonViewPrevious.Size = new Size(123, 44);
            buttonViewPrevious.TabIndex = 0;
            buttonViewPrevious.TabStop = false;
            buttonViewPrevious.Text = "Previous";
            buttonViewPrevious.UseVisualStyleBackColor = true;
            buttonViewPrevious.Click += buttonViewPrevious_Click;
            // 
            // buttonViewNext
            // 
            buttonViewNext.AutoSize = true;
            buttonViewNext.Dock = DockStyle.Fill;
            buttonViewNext.Enabled = false;
            buttonViewNext.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonViewNext.Location = new Point(953, 3);
            buttonViewNext.MinimumSize = new Size(100, 40);
            buttonViewNext.Name = "buttonViewNext";
            buttonViewNext.Size = new Size(100, 44);
            buttonViewNext.TabIndex = 0;
            buttonViewNext.TabStop = false;
            buttonViewNext.Text = "Next";
            buttonViewNext.UseVisualStyleBackColor = true;
            buttonViewNext.Click += buttonViewNext_Click;
            // 
            // flowLayoutPanelViewControll
            // 
            flowLayoutPanelViewControll.AutoSize = true;
            flowLayoutPanelViewControll.Controls.Add(textBoxViewCurrentImage);
            flowLayoutPanelViewControll.Controls.Add(labelViewMaxImages);
            flowLayoutPanelViewControll.Dock = DockStyle.Fill;
            flowLayoutPanelViewControll.Location = new Point(839, 3);
            flowLayoutPanelViewControll.Name = "flowLayoutPanelViewControll";
            flowLayoutPanelViewControll.Size = new Size(108, 44);
            flowLayoutPanelViewControll.TabIndex = 3;
            flowLayoutPanelViewControll.WrapContents = false;
            // 
            // textBoxViewCurrentImage
            // 
            textBoxViewCurrentImage.Dock = DockStyle.Fill;
            textBoxViewCurrentImage.Location = new Point(3, 3);
            textBoxViewCurrentImage.MinimumSize = new Size(35, 4);
            textBoxViewCurrentImage.Name = "textBoxViewCurrentImage";
            textBoxViewCurrentImage.Size = new Size(60, 39);
            textBoxViewCurrentImage.TabIndex = 0;
            textBoxViewCurrentImage.TabStop = false;
            textBoxViewCurrentImage.Text = "1";
            textBoxViewCurrentImage.TextAlign = HorizontalAlignment.Right;
            textBoxViewCurrentImage.TextChanged += textBoxViewCurrentImage_TextChanged;
            // 
            // labelViewMaxImages
            // 
            labelViewMaxImages.AutoSize = true;
            labelViewMaxImages.Dock = DockStyle.Fill;
            labelViewMaxImages.Location = new Point(69, 0);
            labelViewMaxImages.MinimumSize = new Size(35, 0);
            labelViewMaxImages.Name = "labelViewMaxImages";
            labelViewMaxImages.Size = new Size(36, 32);
            labelViewMaxImages.TabIndex = 1;
            labelViewMaxImages.Text = "/1";
            // 
            // checkBoxViewOrignianResolution
            // 
            checkBoxViewOrignianResolution.AutoSize = true;
            checkBoxViewOrignianResolution.Checked = true;
            checkBoxViewOrignianResolution.CheckState = CheckState.Checked;
            checkBoxViewOrignianResolution.Dock = DockStyle.Right;
            checkBoxViewOrignianResolution.Location = new Point(1518, 3);
            checkBoxViewOrignianResolution.Name = "checkBoxViewOrignianResolution";
            checkBoxViewOrignianResolution.Size = new Size(243, 44);
            checkBoxViewOrignianResolution.TabIndex = 0;
            checkBoxViewOrignianResolution.TabStop = false;
            checkBoxViewOrignianResolution.Text = "Original Resolution";
            checkBoxViewOrignianResolution.UseVisualStyleBackColor = true;
            checkBoxViewOrignianResolution.CheckedChanged += checkBoxViewOrignianResolution_CheckedChanged;
            // 
            // pictureBoxView
            // 
            pictureBoxView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxView.BackColor = Color.Transparent;
            pictureBoxView.ErrorImage = Properties.Resources.fileError;
            pictureBoxView.Image = Properties.Resources.image;
            pictureBoxView.InitialImage = null;
            pictureBoxView.Location = new Point(0, 0);
            pictureBoxView.Margin = new Padding(0);
            pictureBoxView.Name = "pictureBoxView";
            pictureBoxView.Size = new Size(1764, 1050);
            pictureBoxView.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxView.TabIndex = 2;
            pictureBoxView.TabStop = false;
            // 
            // tabPageEdit
            // 
            tabPageEdit.Controls.Add(tabControlEdit);
            tabPageEdit.Location = new Point(4, 37);
            tabPageEdit.Name = "tabPageEdit";
            tabPageEdit.Size = new Size(1770, 1103);
            tabPageEdit.TabIndex = 2;
            tabPageEdit.Text = "Edit";
            tabPageEdit.UseVisualStyleBackColor = true;
            // 
            // tabControlEdit
            // 
            tabControlEdit.Controls.Add(tabPageEditNew);
            tabControlEdit.Controls.Add(tabPageEditExport);
            tabControlEdit.Controls.Add(tabPageModify);
            tabControlEdit.Dock = DockStyle.Fill;
            tabControlEdit.Location = new Point(0, 0);
            tabControlEdit.Name = "tabControlEdit";
            tabControlEdit.SelectedIndex = 0;
            tabControlEdit.Size = new Size(1770, 1103);
            tabControlEdit.TabIndex = 0;
            // 
            // tabPageEditNew
            // 
            tabPageEditNew.Controls.Add(tableLayoutPanelEditNew);
            tabPageEditNew.Font = new Font("Segoe UI", 12F);
            tabPageEditNew.Location = new Point(4, 37);
            tabPageEditNew.Name = "tabPageEditNew";
            tabPageEditNew.Padding = new Padding(3);
            tabPageEditNew.Size = new Size(1762, 1062);
            tabPageEditNew.TabIndex = 0;
            tabPageEditNew.Text = "Create New";
            tabPageEditNew.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelEditNew
            // 
            tableLayoutPanelEditNew.ColumnCount = 3;
            tableLayoutPanelEditNew.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanelEditNew.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditNew.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanelEditNew.Controls.Add(labelEditNewTitle, 0, 0);
            tableLayoutPanelEditNew.Controls.Add(labelEditNewCover, 0, 1);
            tableLayoutPanelEditNew.Controls.Add(textBoxEditNewTitle, 1, 0);
            tableLayoutPanelEditNew.Controls.Add(textBoxEditNewCoverPath, 1, 1);
            tableLayoutPanelEditNew.Controls.Add(buttonEditNewCover, 2, 1);
            tableLayoutPanelEditNew.Controls.Add(listViewEditNewImages, 1, 2);
            tableLayoutPanelEditNew.Controls.Add(buttonEditNewCreate, 2, 0);
            tableLayoutPanelEditNew.Controls.Add(buttonEditNewRemoveImage, 2, 2);
            tableLayoutPanelEditNew.Controls.Add(tableLayoutPanelEditNewLeftControll, 0, 2);
            tableLayoutPanelEditNew.Dock = DockStyle.Fill;
            tableLayoutPanelEditNew.Location = new Point(3, 3);
            tableLayoutPanelEditNew.Name = "tableLayoutPanelEditNew";
            tableLayoutPanelEditNew.RowCount = 3;
            tableLayoutPanelEditNew.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanelEditNew.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanelEditNew.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditNew.Size = new Size(1756, 1056);
            tableLayoutPanelEditNew.TabIndex = 0;
            // 
            // labelEditNewTitle
            // 
            labelEditNewTitle.AutoSize = true;
            labelEditNewTitle.Dock = DockStyle.Fill;
            labelEditNewTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEditNewTitle.Location = new Point(3, 0);
            labelEditNewTitle.Name = "labelEditNewTitle";
            labelEditNewTitle.Size = new Size(244, 60);
            labelEditNewTitle.TabIndex = 0;
            labelEditNewTitle.Text = "Title:";
            // 
            // labelEditNewCover
            // 
            labelEditNewCover.AutoSize = true;
            labelEditNewCover.Dock = DockStyle.Fill;
            labelEditNewCover.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEditNewCover.Location = new Point(3, 60);
            labelEditNewCover.Name = "labelEditNewCover";
            labelEditNewCover.Size = new Size(244, 60);
            labelEditNewCover.TabIndex = 1;
            labelEditNewCover.Text = "Cover Image:";
            // 
            // textBoxEditNewTitle
            // 
            textBoxEditNewTitle.Dock = DockStyle.Fill;
            textBoxEditNewTitle.Location = new Point(253, 3);
            textBoxEditNewTitle.Name = "textBoxEditNewTitle";
            textBoxEditNewTitle.Size = new Size(1278, 39);
            textBoxEditNewTitle.TabIndex = 0;
            textBoxEditNewTitle.TextChanged += textBoxEditNewTitle_TextChanged;
            // 
            // textBoxEditNewCoverPath
            // 
            textBoxEditNewCoverPath.Dock = DockStyle.Fill;
            textBoxEditNewCoverPath.Location = new Point(253, 63);
            textBoxEditNewCoverPath.Name = "textBoxEditNewCoverPath";
            textBoxEditNewCoverPath.ReadOnly = true;
            textBoxEditNewCoverPath.Size = new Size(1278, 39);
            textBoxEditNewCoverPath.TabIndex = 0;
            textBoxEditNewCoverPath.TabStop = false;
            // 
            // buttonEditNewCover
            // 
            buttonEditNewCover.AutoSize = true;
            buttonEditNewCover.Dock = DockStyle.Fill;
            buttonEditNewCover.Location = new Point(1544, 66);
            buttonEditNewCover.Margin = new Padding(10, 6, 10, 6);
            buttonEditNewCover.Name = "buttonEditNewCover";
            buttonEditNewCover.Padding = new Padding(5, 0, 5, 0);
            buttonEditNewCover.Size = new Size(202, 48);
            buttonEditNewCover.TabIndex = 0;
            buttonEditNewCover.Text = "Search";
            buttonEditNewCover.UseVisualStyleBackColor = true;
            buttonEditNewCover.Click += buttonEditNewCover_Click;
            // 
            // listViewEditNewImages
            // 
            listViewEditNewImages.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEditNewImages.Columns.AddRange(new ColumnHeader[] { columnHeaderModifyNew });
            listViewEditNewImages.FullRowSelect = true;
            listViewEditNewImages.GridLines = true;
            listViewEditNewImages.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewEditNewImages.Location = new Point(253, 123);
            listViewEditNewImages.Name = "listViewEditNewImages";
            listViewEditNewImages.Size = new Size(1278, 930);
            listViewEditNewImages.TabIndex = 7;
            listViewEditNewImages.TabStop = false;
            listViewEditNewImages.UseCompatibleStateImageBehavior = false;
            listViewEditNewImages.View = View.Details;
            listViewEditNewImages.SelectedIndexChanged += listViewEditNewImages_SelectedIndexChanged;
            // 
            // columnHeaderModifyNew
            // 
            columnHeaderModifyNew.Text = "Image";
            columnHeaderModifyNew.Width = 9999;
            // 
            // buttonEditNewCreate
            // 
            buttonEditNewCreate.Dock = DockStyle.Fill;
            buttonEditNewCreate.Enabled = false;
            buttonEditNewCreate.Location = new Point(1544, 6);
            buttonEditNewCreate.Margin = new Padding(10, 6, 10, 6);
            buttonEditNewCreate.Name = "buttonEditNewCreate";
            buttonEditNewCreate.Padding = new Padding(5, 0, 5, 0);
            buttonEditNewCreate.Size = new Size(202, 48);
            buttonEditNewCreate.TabIndex = 2;
            buttonEditNewCreate.Text = "Create";
            buttonEditNewCreate.UseVisualStyleBackColor = true;
            buttonEditNewCreate.Click += buttonEditNewCreate_Click;
            // 
            // buttonEditNewRemoveImage
            // 
            buttonEditNewRemoveImage.AutoSize = true;
            buttonEditNewRemoveImage.Dock = DockStyle.Top;
            buttonEditNewRemoveImage.Enabled = false;
            buttonEditNewRemoveImage.Location = new Point(1544, 126);
            buttonEditNewRemoveImage.Margin = new Padding(10, 6, 10, 6);
            buttonEditNewRemoveImage.Name = "buttonEditNewRemoveImage";
            buttonEditNewRemoveImage.Padding = new Padding(5, 0, 5, 0);
            buttonEditNewRemoveImage.Size = new Size(202, 42);
            buttonEditNewRemoveImage.TabIndex = 0;
            buttonEditNewRemoveImage.TabStop = false;
            buttonEditNewRemoveImage.Text = "Delete Selected";
            buttonEditNewRemoveImage.UseVisualStyleBackColor = true;
            buttonEditNewRemoveImage.Click += buttonEditNewRemoveImage_Click;
            // 
            // tableLayoutPanelEditNewLeftControll
            // 
            tableLayoutPanelEditNewLeftControll.ColumnCount = 1;
            tableLayoutPanelEditNewLeftControll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditNewLeftControll.Controls.Add(buttonEditNewAddImage, 0, 0);
            tableLayoutPanelEditNewLeftControll.Controls.Add(textBoxEditNewTags, 0, 2);
            tableLayoutPanelEditNewLeftControll.Controls.Add(labelEditNewTags, 0, 1);
            tableLayoutPanelEditNewLeftControll.Dock = DockStyle.Fill;
            tableLayoutPanelEditNewLeftControll.Location = new Point(3, 123);
            tableLayoutPanelEditNewLeftControll.Name = "tableLayoutPanelEditNewLeftControll";
            tableLayoutPanelEditNewLeftControll.RowCount = 3;
            tableLayoutPanelEditNewLeftControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditNewLeftControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditNewLeftControll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditNewLeftControll.Size = new Size(244, 930);
            tableLayoutPanelEditNewLeftControll.TabIndex = 8;
            // 
            // buttonEditNewAddImage
            // 
            buttonEditNewAddImage.AutoSize = true;
            buttonEditNewAddImage.Dock = DockStyle.Top;
            buttonEditNewAddImage.Location = new Point(10, 6);
            buttonEditNewAddImage.Margin = new Padding(10, 6, 10, 6);
            buttonEditNewAddImage.Name = "buttonEditNewAddImage";
            buttonEditNewAddImage.Padding = new Padding(5, 0, 5, 0);
            buttonEditNewAddImage.Size = new Size(224, 42);
            buttonEditNewAddImage.TabIndex = 2;
            buttonEditNewAddImage.Text = "Add Image";
            buttonEditNewAddImage.UseVisualStyleBackColor = true;
            buttonEditNewAddImage.Click += buttonEditNewAddImage_Click;
            // 
            // textBoxEditNewTags
            // 
            textBoxEditNewTags.AcceptsReturn = true;
            textBoxEditNewTags.BackColor = Color.FromArgb(224, 224, 224);
            textBoxEditNewTags.Dock = DockStyle.Fill;
            textBoxEditNewTags.Location = new Point(3, 89);
            textBoxEditNewTags.Multiline = true;
            textBoxEditNewTags.Name = "textBoxEditNewTags";
            textBoxEditNewTags.Size = new Size(238, 838);
            textBoxEditNewTags.TabIndex = 3;
            // 
            // labelEditNewTags
            // 
            labelEditNewTags.AutoSize = true;
            labelEditNewTags.Dock = DockStyle.Fill;
            labelEditNewTags.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEditNewTags.Location = new Point(3, 54);
            labelEditNewTags.Name = "labelEditNewTags";
            labelEditNewTags.Size = new Size(238, 32);
            labelEditNewTags.TabIndex = 4;
            labelEditNewTags.Text = "Tags (one per line):";
            labelEditNewTags.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageEditExport
            // 
            tabPageEditExport.Controls.Add(tableLayoutPanelEditExport);
            tabPageEditExport.Location = new Point(4, 34);
            tabPageEditExport.Name = "tabPageEditExport";
            tabPageEditExport.Padding = new Padding(3);
            tabPageEditExport.Size = new Size(1762, 1065);
            tabPageEditExport.TabIndex = 1;
            tabPageEditExport.Text = "Export";
            tabPageEditExport.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelEditExport
            // 
            tableLayoutPanelEditExport.ColumnCount = 1;
            tableLayoutPanelEditExport.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditExport.Controls.Add(buttonEditExport, 0, 1);
            tableLayoutPanelEditExport.Controls.Add(listViewEditExport, 0, 0);
            tableLayoutPanelEditExport.Dock = DockStyle.Fill;
            tableLayoutPanelEditExport.Location = new Point(3, 3);
            tableLayoutPanelEditExport.Name = "tableLayoutPanelEditExport";
            tableLayoutPanelEditExport.RowCount = 2;
            tableLayoutPanelEditExport.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditExport.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditExport.Size = new Size(1756, 1059);
            tableLayoutPanelEditExport.TabIndex = 0;
            // 
            // buttonEditExport
            // 
            buttonEditExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEditExport.AutoSize = true;
            buttonEditExport.Enabled = false;
            buttonEditExport.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            buttonEditExport.Location = new Point(10, 1011);
            buttonEditExport.Margin = new Padding(10, 6, 10, 6);
            buttonEditExport.Name = "buttonEditExport";
            buttonEditExport.Padding = new Padding(5, 0, 5, 0);
            buttonEditExport.Size = new Size(1736, 42);
            buttonEditExport.TabIndex = 0;
            buttonEditExport.Text = "Export";
            buttonEditExport.UseVisualStyleBackColor = true;
            buttonEditExport.Click += buttonEditExport_Click;
            // 
            // listViewEditExport
            // 
            listViewEditExport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewEditExport.Columns.AddRange(new ColumnHeader[] { columnHeaderName });
            listViewEditExport.FullRowSelect = true;
            listViewEditExport.Location = new Point(0, 0);
            listViewEditExport.Margin = new Padding(0);
            listViewEditExport.MultiSelect = false;
            listViewEditExport.Name = "listViewEditExport";
            listViewEditExport.Size = new Size(1756, 1005);
            listViewEditExport.Sorting = SortOrder.Ascending;
            listViewEditExport.TabIndex = 1;
            listViewEditExport.UseCompatibleStateImageBehavior = false;
            listViewEditExport.View = View.Details;
            listViewEditExport.SelectedIndexChanged += listViewEditExport_SelectedIndexChanged;
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 9999;
            // 
            // tabPageModify
            // 
            tabPageModify.Controls.Add(tableLayoutPanelEditModify);
            tabPageModify.Location = new Point(4, 37);
            tabPageModify.Name = "tabPageModify";
            tabPageModify.Size = new Size(1762, 1062);
            tabPageModify.TabIndex = 2;
            tabPageModify.Text = "Modify";
            tabPageModify.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelEditModify
            // 
            tableLayoutPanelEditModify.ColumnCount = 2;
            tableLayoutPanelEditModify.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditModify.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 400F));
            tableLayoutPanelEditModify.Controls.Add(tableLayoutPanelEditModifyControll, 1, 0);
            tableLayoutPanelEditModify.Controls.Add(listViewEditModify, 0, 0);
            tableLayoutPanelEditModify.Dock = DockStyle.Fill;
            tableLayoutPanelEditModify.Location = new Point(0, 0);
            tableLayoutPanelEditModify.Name = "tableLayoutPanelEditModify";
            tableLayoutPanelEditModify.RowCount = 1;
            tableLayoutPanelEditModify.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditModify.Size = new Size(1762, 1062);
            tableLayoutPanelEditModify.TabIndex = 0;
            // 
            // tableLayoutPanelEditModifyControll
            // 
            tableLayoutPanelEditModifyControll.ColumnCount = 1;
            tableLayoutPanelEditModifyControll.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditModifyControll.Controls.Add(buttonEditModifyAttach, 0, 0);
            tableLayoutPanelEditModifyControll.Controls.Add(buttonEditModifyRemove, 0, 1);
            tableLayoutPanelEditModifyControll.Controls.Add(buttonEditModifyInsert, 0, 2);
            tableLayoutPanelEditModifyControll.Controls.Add(buttonEditModifySelect, 0, 3);
            tableLayoutPanelEditModifyControll.Controls.Add(buttonEditModifyConfirm, 0, 6);
            tableLayoutPanelEditModifyControll.Controls.Add(tableLayoutPanel1, 0, 4);
            tableLayoutPanelEditModifyControll.Dock = DockStyle.Fill;
            tableLayoutPanelEditModifyControll.Location = new Point(1365, 3);
            tableLayoutPanelEditModifyControll.Name = "tableLayoutPanelEditModifyControll";
            tableLayoutPanelEditModifyControll.RowCount = 7;
            tableLayoutPanelEditModifyControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditModifyControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditModifyControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditModifyControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditModifyControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditModifyControll.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelEditModifyControll.RowStyles.Add(new RowStyle());
            tableLayoutPanelEditModifyControll.Size = new Size(394, 1056);
            tableLayoutPanelEditModifyControll.TabIndex = 0;
            // 
            // buttonEditModifyAttach
            // 
            buttonEditModifyAttach.AutoSize = true;
            buttonEditModifyAttach.Dock = DockStyle.Fill;
            buttonEditModifyAttach.Enabled = false;
            buttonEditModifyAttach.Font = new Font("Segoe UI", 12F);
            buttonEditModifyAttach.Location = new Point(10, 6);
            buttonEditModifyAttach.Margin = new Padding(10, 6, 10, 6);
            buttonEditModifyAttach.Name = "buttonEditModifyAttach";
            buttonEditModifyAttach.Padding = new Padding(5, 0, 5, 0);
            buttonEditModifyAttach.Size = new Size(374, 48);
            buttonEditModifyAttach.TabIndex = 0;
            buttonEditModifyAttach.Text = "Attach";
            buttonEditModifyAttach.UseVisualStyleBackColor = true;
            buttonEditModifyAttach.Click += buttonEditModifyAttach_Click;
            // 
            // buttonEditModifyRemove
            // 
            buttonEditModifyRemove.AutoSize = true;
            buttonEditModifyRemove.Dock = DockStyle.Fill;
            buttonEditModifyRemove.Enabled = false;
            buttonEditModifyRemove.Font = new Font("Segoe UI", 12F);
            buttonEditModifyRemove.Location = new Point(10, 66);
            buttonEditModifyRemove.Margin = new Padding(10, 6, 10, 6);
            buttonEditModifyRemove.Name = "buttonEditModifyRemove";
            buttonEditModifyRemove.Padding = new Padding(5, 0, 5, 0);
            buttonEditModifyRemove.Size = new Size(374, 48);
            buttonEditModifyRemove.TabIndex = 1;
            buttonEditModifyRemove.Text = "Remove";
            buttonEditModifyRemove.UseVisualStyleBackColor = true;
            buttonEditModifyRemove.Click += buttonEditModifyRemove_Click;
            // 
            // buttonEditModifyInsert
            // 
            buttonEditModifyInsert.AutoSize = true;
            buttonEditModifyInsert.Dock = DockStyle.Fill;
            buttonEditModifyInsert.Enabled = false;
            buttonEditModifyInsert.Font = new Font("Segoe UI", 12F);
            buttonEditModifyInsert.Location = new Point(10, 126);
            buttonEditModifyInsert.Margin = new Padding(10, 6, 10, 6);
            buttonEditModifyInsert.Name = "buttonEditModifyInsert";
            buttonEditModifyInsert.Padding = new Padding(5, 0, 5, 0);
            buttonEditModifyInsert.Size = new Size(374, 48);
            buttonEditModifyInsert.TabIndex = 2;
            buttonEditModifyInsert.Text = "Insert";
            buttonEditModifyInsert.UseVisualStyleBackColor = true;
            buttonEditModifyInsert.Click += buttonEditModifyInsert_Click;
            // 
            // buttonEditModifySelect
            // 
            buttonEditModifySelect.AutoSize = true;
            buttonEditModifySelect.Dock = DockStyle.Fill;
            buttonEditModifySelect.Font = new Font("Segoe UI", 12F);
            buttonEditModifySelect.Location = new Point(10, 186);
            buttonEditModifySelect.Margin = new Padding(10, 6, 10, 6);
            buttonEditModifySelect.Name = "buttonEditModifySelect";
            buttonEditModifySelect.Padding = new Padding(5, 0, 5, 0);
            buttonEditModifySelect.Size = new Size(374, 48);
            buttonEditModifySelect.TabIndex = 3;
            buttonEditModifySelect.Text = "Choose Album";
            buttonEditModifySelect.UseVisualStyleBackColor = true;
            buttonEditModifySelect.Click += buttonEditModifySelect_Click;
            // 
            // buttonEditModifyConfirm
            // 
            buttonEditModifyConfirm.AutoSize = true;
            buttonEditModifyConfirm.Dock = DockStyle.Fill;
            buttonEditModifyConfirm.Enabled = false;
            buttonEditModifyConfirm.Font = new Font("Segoe UI", 12F);
            buttonEditModifyConfirm.Location = new Point(10, 1002);
            buttonEditModifyConfirm.Margin = new Padding(10, 6, 10, 6);
            buttonEditModifyConfirm.Name = "buttonEditModifyConfirm";
            buttonEditModifyConfirm.Padding = new Padding(5, 0, 5, 0);
            buttonEditModifyConfirm.Size = new Size(374, 48);
            buttonEditModifyConfirm.TabIndex = 4;
            buttonEditModifyConfirm.Text = "Confirm";
            buttonEditModifyConfirm.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(buttonEditModifySwitchPlaces, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 243);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(388, 50);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // buttonEditModifySwitchPlaces
            // 
            buttonEditModifySwitchPlaces.AutoSize = true;
            buttonEditModifySwitchPlaces.Font = new Font("Segoe UI", 12F);
            buttonEditModifySwitchPlaces.Location = new Point(10, 6);
            buttonEditModifySwitchPlaces.Margin = new Padding(10, 6, 10, 2);
            buttonEditModifySwitchPlaces.Name = "buttonEditModifySwitchPlaces";
            buttonEditModifySwitchPlaces.Padding = new Padding(5, 0, 5, 0);
            buttonEditModifySwitchPlaces.Size = new Size(294, 42);
            buttonEditModifySwitchPlaces.TabIndex = 4;
            buttonEditModifySwitchPlaces.Text = "Switch Places with";
            buttonEditModifySwitchPlaces.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI", 12F);
            textBox1.Location = new Point(317, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(68, 39);
            textBox1.TabIndex = 1;
            // 
            // listViewEditModify
            // 
            listViewEditModify.Columns.AddRange(new ColumnHeader[] { columnHeaderModifyName });
            listViewEditModify.Dock = DockStyle.Fill;
            listViewEditModify.FullRowSelect = true;
            listViewEditModify.GridLines = true;
            listViewEditModify.Location = new Point(3, 3);
            listViewEditModify.Name = "listViewEditModify";
            listViewEditModify.Size = new Size(1356, 1056);
            listViewEditModify.Sorting = SortOrder.Ascending;
            listViewEditModify.TabIndex = 1;
            listViewEditModify.UseCompatibleStateImageBehavior = false;
            listViewEditModify.View = View.Details;
            // 
            // columnHeaderModifyName
            // 
            columnHeaderModifyName.Text = "Album";
            columnHeaderModifyName.Width = 9999;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 1144);
            Controls.Add(tabControlMain);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            MinimumSize = new Size(1800, 1200);
            Name = "FormMain";
            ShowIcon = false;
            Text = "PrivMage";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            tabControlMain.ResumeLayout(false);
            tabPageSelect.ResumeLayout(false);
            splitContainerSelect.Panel1.ResumeLayout(false);
            splitContainerSelect.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerSelect).EndInit();
            splitContainerSelect.ResumeLayout(false);
            tableLayoutPanelSelectInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxSelectPreview).EndInit();
            tableLayoutPanelSelectInfoLabels.ResumeLayout(false);
            tableLayoutPanelSelectInfoLabels.PerformLayout();
            tabPageView.ResumeLayout(false);
            tableLayoutPanelView.ResumeLayout(false);
            tableLayoutPanelViewControll.ResumeLayout(false);
            tableLayoutPanelViewControll.PerformLayout();
            flowLayoutPanelViewControll.ResumeLayout(false);
            flowLayoutPanelViewControll.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxView).EndInit();
            tabPageEdit.ResumeLayout(false);
            tabControlEdit.ResumeLayout(false);
            tabPageEditNew.ResumeLayout(false);
            tableLayoutPanelEditNew.ResumeLayout(false);
            tableLayoutPanelEditNew.PerformLayout();
            tableLayoutPanelEditNewLeftControll.ResumeLayout(false);
            tableLayoutPanelEditNewLeftControll.PerformLayout();
            tabPageEditExport.ResumeLayout(false);
            tableLayoutPanelEditExport.ResumeLayout(false);
            tableLayoutPanelEditExport.PerformLayout();
            tabPageModify.ResumeLayout(false);
            tableLayoutPanelEditModify.ResumeLayout(false);
            tableLayoutPanelEditModifyControll.ResumeLayout(false);
            tableLayoutPanelEditModifyControll.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private ArrowlessTabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.TabPage tabPageEdit;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelView;
        private System.Windows.Forms.CheckBox checkBoxViewOrignianResolution;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelViewControll;
        private System.Windows.Forms.Button buttonViewPrevious;
        private System.Windows.Forms.Button buttonViewNext;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelViewControll;
        private System.Windows.Forms.TextBox textBoxViewCurrentImage;
        private System.Windows.Forms.Label labelViewMaxImages;
        private System.Windows.Forms.PictureBox pictureBoxView;
        private ArrowlessTabControl tabControlEdit;
        private System.Windows.Forms.TabPage tabPageEditNew;
        private System.Windows.Forms.TabPage tabPageEditExport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEditNew;
        private System.Windows.Forms.TextBox textBoxEditNewTitle;
        private System.Windows.Forms.TextBox textBoxEditNewCoverPath;
        private System.Windows.Forms.Button buttonEditNewCover;
        private System.Windows.Forms.Button buttonEditNewRemoveImage;
        private System.Windows.Forms.ListView listViewEditNewImages;
        private System.Windows.Forms.Button buttonEditNewCreate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEditExport;
        private System.Windows.Forms.Button buttonEditExport;
        private System.Windows.Forms.ListView listViewEditExport;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private Label labelEditNewTitle;
        private Label labelEditNewCover;
        private TableLayoutPanel tableLayoutPanelEditNewLeftControll;
        private Button buttonEditNewAddImage;
        private TextBox textBoxEditNewTags;
        private Label labelEditNewTags;
        private SplitContainer splitContainerSelect;
        private ListView listViewSelect;
        private TableLayoutPanel tableLayoutPanelSelectInfo;
        private PictureBox pictureBoxSelectPreview;
        private TableLayoutPanel tableLayoutPanelSelectInfoLabels;
        private Label labelSelectInfoName;
        private Label labelSelectInfoDate;
        private Label labelSelectInfoTags;
        private Button buttonSelectRead;
        private Label labelSelectInfoID;
        private TabPage tabPageModify;
        private TableLayoutPanel tableLayoutPanelEditModify;
        private TableLayoutPanel tableLayoutPanelEditModifyControll;
        private Button buttonEditModifyAttach;
        private Button buttonEditModifyRemove;
        private ListView listViewEditModify;
        private Button buttonEditModifyInsert;
        private Button buttonEditModifySelect;
        private ColumnHeader columnHeaderModifyName;
        private Button buttonEditModifyConfirm;
        private ColumnHeader columnHeaderModifyNew;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonEditModifySwitchPlaces;
        private TextBox textBox1;
    }
}

