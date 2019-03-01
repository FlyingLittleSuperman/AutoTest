package util.JTree;

import WinForm.prodef.ProPackage;
import WinForm.prodef.Prodef;
import WinForm.prodef.ProdefTree;

import javax.swing.*;
import javax.swing.tree.DefaultMutableTreeNode;
import javax.swing.tree.DefaultTreeModel;
import javax.swing.tree.TreePath;
import java.awt.event.MouseAdapter;
import java.awt.event.MouseEvent;

/**
 * Created by Administrator on 2016/12/16.
 */
public class CheckBoxTreeNodeSelectionListener extends MouseAdapter {

    public Callback getCallback() {
        return callback;
    }

    public void setCallback(Callback callback) {
        this.callback = callback;
    }

    private Callback callback;


    @Override
    public void mouseClicked(MouseEvent event) {

        JTree tree = (JTree) event.getSource();
        int x = event.getX();
        int y = event.getY();
        int row = tree.getRowForLocation(x, y);
        String selectId = "";
        Boolean isHaveChildNode = true;
        CheckBoxTreeNode node;
        DefaultMutableTreeNode nodeDefault;
        TreePath path = tree.getPathForRow(row);
        if (path != null) {
            if ((path.getLastPathComponent() instanceof CheckBoxTreeNode)) {
                node = (CheckBoxTreeNode) path.getLastPathComponent();
                if (node.getUserObject() instanceof Prodef) {
                    Prodef prodef = ((Prodef) node.getUserObject());
                    selectId = prodef.getKey();
                    callback.executeSelect(prodef, node); //回调函数
                    int count = node.getChildCount();
                    if (count == 0) {
                        isHaveChildNode = false;
                    }

                    if (!isHaveChildNode) {
                        try {
                            ProdefTree.GetActDefInfo(selectId, node);
                            if (event.getClickCount() == 2) { // 表示鼠标双击
                                tree.expandPath(path);
                            }
                        } catch (Exception er) {
                            throw new RuntimeException(er.getMessage());
                        }
                    }

                    if (node != null) {
                        boolean isSelected = !node.isSelected();
                        node.setSelected(isSelected);
                        ((DefaultTreeModel) tree.getModel()).nodeStructureChanged(node);
                    }

                } else {
                    if (node != null) {
                        boolean isSelected = !node.isSelected();
                        node.setSelected(isSelected);
                        ((DefaultTreeModel) tree.getModel()).nodeStructureChanged(node);
                    }
                }
            } else {

                nodeDefault = (DefaultMutableTreeNode) path.getLastPathComponent();
                if (nodeDefault.getUserObject() instanceof ProPackage) {
                    selectId = ((ProPackage) nodeDefault.getUserObject()).getId();
                    int count = nodeDefault.getChildCount();
                    if (count == 0) {
                        isHaveChildNode = false;
                    }
                    if (event.getClickCount() == 2) { // 表示鼠标双击
                        if (!isHaveChildNode) {
                            try {
                                ProdefTree.GetProdefNode(selectId, nodeDefault);
                                tree.expandPath(path);
                            } catch (Exception er) {
                                throw new RuntimeException(er.getMessage());
                            }
                        }
                    }
                }
            }
        }
    }

}