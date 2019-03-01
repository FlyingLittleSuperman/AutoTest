package WinForm;

import WinForm.prodef.ProPackage;
import WinForm.prodef.Prodef;
import WinForm.prodef.ProdefTree;
import WinForm.xml.JTreeXML;
import util.JTree.Callback;
import util.JTree.CheckBoxTreeCellRenderer;
import util.JTree.CheckBoxTreeNode;
import util.JTree.CheckBoxTreeNodeSelectionListener;

import javax.swing.*;
import javax.swing.table.DefaultTableCellRenderer;
import javax.swing.table.DefaultTableModel;
import javax.swing.table.JTableHeader;
import javax.swing.table.TableColumn;
import javax.swing.tree.DefaultMutableTreeNode;
import javax.swing.tree.TreeNode;
import javax.swing.tree.TreePath;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.*;
import java.util.List;


/**
 * Created by Administrator on 2016/12/15.
 * private JButton button4;
 * private JPanel jSelectPro;
 */
public class SeleniumConfig implements Callback {
    private JPanel jPanel;
    private JTabbedPane tabSelectProdef;
    private JTree treeProdef;
    private JButton btnSave;
    private JTextField txtProdefName;
    private JTextField txtProdefId;
    private JTextField txtPackageName;
    private JTextField textField4;
    private JTextField textField5;
    private JTable tableHaveSelect;
    private Map<Prodef, ProPackage> allSelectNodes;
    private List<ProPackage> allPropackage;


    public SeleniumConfig() throws Exception {
        btnSave.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                try {
                    allSelectNodes = new HashMap<Prodef, ProPackage>();
                    allPropackage = new ArrayList<ProPackage>();
                    GetSelectCheckNode();
                    JTreeXML.SaveXml(allSelectNodes, allPropackage);
                } catch (Exception er) {
                    JOptionPane.showMessageDialog(jPanel, er.getMessage(), "标题", JOptionPane.WARNING_MESSAGE);
                }


            }
        });
    }

    private void GetSelectCheckNode() {
        TreeNode root = (TreeNode) treeProdef.getModel().getRoot();
        expandAll(treeProdef, new TreePath(root), true);
    }

    private void expandAll(JTree tree, TreePath parent, boolean expand) {
        // Traverse children
        TreeNode node = (TreeNode) parent.getLastPathComponent();
        if (node.getChildCount() >= 0) {
            for (Enumeration e = node.children(); e.hasMoreElements(); ) {
                TreeNode n = (TreeNode) e.nextElement();
                if (n instanceof CheckBoxTreeNode) {
                    if (((CheckBoxTreeNode) n).getUserObject() instanceof Prodef) {
                        TreeNode parentNode = node.getParent();
                        if (((CheckBoxTreeNode) n).isSelected()) {
                            ProPackage proPackage = (ProPackage) ((DefaultMutableTreeNode) parentNode).getUserObject();
                            Prodef prodef = (Prodef) ((CheckBoxTreeNode) n).getUserObject();
                            allSelectNodes.put(prodef, proPackage);
                            if (!allPropackage.contains(proPackage)) {
                                TreePath path = new TreePath(((CheckBoxTreeNode) n).getPath());
                                proPackage.setDescription(path.toString().replace("流程管理,", "").replace(", " + prodef.getName(), "").replace("[", "").replace("]", "").replace(",", "-"));
                                allPropackage.add(proPackage);
                            }
                        }
                    }
                }
                TreePath path = parent.pathByAddingChild(n);
                expandAll(tree, path, expand);
            }
        }
    }


    public static void main(String[] args) throws Exception {
        JFrame jframe = new JFrame("SeleniumConfig");
        try {

            jframe.setTitle("测试窗体");
            JPanel rootPane = new SeleniumConfig().jPanel;

            jframe.setContentPane(rootPane);
            jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
            jframe.pack();
            Dimension screensize = Toolkit.getDefaultToolkit().getScreenSize();
            jframe.setSize(((Double) screensize.getWidth()).intValue(), ((Double) screensize.getHeight()).intValue());
            jframe.setLocationRelativeTo(rootPane);//居中
            jframe.setVisible(true);
        } catch (Exception er) {
            JOptionPane.showMessageDialog(jframe, er.getMessage(), "标题", JOptionPane.WARNING_MESSAGE);
        }

    }

    private void createUIComponents() throws Exception {
        DefaultMutableTreeNode top = new DefaultMutableTreeNode("流程管理");
        ProdefTree.GetPackage(top, "");
        treeProdef = new JTree(top);
        CheckBoxTreeNodeSelectionListener listener = new CheckBoxTreeNodeSelectionListener();
        listener.setCallback(this);
        treeProdef.addMouseListener(listener);
        treeProdef.setCellRenderer(new CheckBoxTreeCellRenderer());

        Object[] columnNames = {"包内码", "包名称", "包描述", "流程名称", "流程内码"};
        Object[][] data = ProdefTree.GetAllSelectProdef();


        tableHaveSelect = new JTable(new DefaultTableModel(data, columnNames));
        tableHaveSelect.setAutoResizeMode(JTable.AUTO_RESIZE_OFF); //处理滚动条
        JTableHeader header = tableHaveSelect.getTableHeader();
        Font font = new Font("TimesRoman", Font.BOLD, 15);
        header.setFont(font);
        DefaultTableCellRenderer render = new DefaultTableCellRenderer();
        render.setHorizontalAlignment(SwingConstants.CENTER);
        tableHaveSelect.getColumn("包内码").setCellRenderer(render);
        SetTableColumnWith("包内码", 250);
        SetTableColumnWith("包名称", 100);
        SetTableColumnWith("包描述", 700);
        SetTableColumnWith("流程名称", 250);
        SetTableColumnWith("流程内码", 100);
        //FitTableColumns(tableHaveSelect);
    }

    /**
     * 设置表格列宽度
     *
     * @param ColumnName
     * @param width
     */
    private void SetTableColumnWith(String ColumnName, int width) {
        TableColumn column = tableHaveSelect.getColumn(ColumnName);
        column.setPreferredWidth(width);
        column.setMinWidth(width);
        column.setMaxWidth(width);
    }

    public void FitTableColumns(JTable myTable) {
        JTableHeader header = myTable.getTableHeader();
        int rowCount = myTable.getRowCount();

        Enumeration columns = myTable.getColumnModel().getColumns();
        while (columns.hasMoreElements()) {
            TableColumn column = (TableColumn) columns.nextElement();
            int col = header.getColumnModel().getColumnIndex(column.getIdentifier());
            int width = (int) myTable.getTableHeader().getDefaultRenderer()
                    .getTableCellRendererComponent(myTable, column.getIdentifier()
                            , false, false, -1, col).getPreferredSize().getWidth();
            for (int row = 0; row < rowCount; row++) {
                int preferedWidth = (int) myTable.getCellRenderer(row, col).getTableCellRendererComponent(myTable,
                        myTable.getValueAt(row, col), false, false, row, col).getPreferredSize().getWidth();
                width = Math.max(width, preferedWidth);
            }
            header.setResizingColumn(column); // 此行很重要
            column.setWidth(width + myTable.getIntercellSpacing().width);
        }
    }


    public void executeSelect(Prodef prodef, CheckBoxTreeNode node) {
        txtProdefId.setText(prodef.getId());
        txtProdefName.setText(prodef.getName());
        TreePath path = new TreePath(((DefaultMutableTreeNode) node.getParent()).getPath());
        txtPackageName.setText(path.toString().replace("流程管理,", "").replace(", " + prodef.getName(), "").replace("[", "").replace("]", "").replace(",", "-"));
        //JOptionPane.showMessageDialog(jPanel, prodef.getId(), "标题", JOptionPane.WARNING_MESSAGE);
    }
}
