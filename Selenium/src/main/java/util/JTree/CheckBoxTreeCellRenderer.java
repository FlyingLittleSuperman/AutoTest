package util.JTree;

import javax.swing.*;
import javax.swing.plaf.ColorUIResource;
import javax.swing.tree.TreeCellRenderer;
import java.awt.*;

/**
 * Created by Administrator on 2016/12/16.
 */
public class CheckBoxTreeCellRenderer extends JPanel implements TreeCellRenderer {
    protected JCheckBox check;
    protected CheckBoxTreeLabel label;

    public CheckBoxTreeCellRenderer() {
        setLayout(null);
        add(check = new JCheckBox());
        add(label = new CheckBoxTreeLabel());
        check.setBackground(UIManager.getColor("Tree.textBackground"));
        //check.setBackground(UIManager.getColor("Tree.textBackground"));
        label.setForeground(UIManager.getColor("Tree.textForeground"));
    }

    /**
     * 返回的是一个<code>JPanel</code>对象，该对象中包含一个<code>JCheckBox</code>对象
     * 和一个<code>JLabel</code>对象。并且根据每个结点是否被选中来决定<code>JCheckBox</code>
     * 是否被选中。
     */
    public Component getTreeCellRendererComponent(JTree tree, Object value,
                                                  boolean selected, boolean expanded, boolean leaf, int row,
                                                  boolean hasFocus) {
        String stringValue = tree.convertValueToText(value, selected, expanded, leaf, row, hasFocus);
        setEnabled(tree.isEnabled());
        if (value instanceof CheckBoxTreeNode) {
            check.setVisible(true);
            check.setEnabled(true);
            check.setSelected(((CheckBoxTreeNode) value).isSelected());
        } else {
            check.setVisible(false);
        }


        label.setFont(tree.getFont());
        label.setText(stringValue);
        label.setSelected(selected);
        label.setFocus(hasFocus);
        if (leaf)
            label.setIcon(UIManager.getIcon("Tree.leafIcon"));
        else if (expanded)
            label.setIcon(UIManager.getIcon("Tree.openIcon"));
        else
            label.setIcon(UIManager.getIcon("Tree.closedIcon"));
        return this;
    }

    @Override
    public Dimension getPreferredSize() {
        if (!check.isVisible()) {
            Dimension dLabel = label.getPreferredSize();
            return new Dimension(dLabel.width, dLabel.height);
        } else {
            Dimension dCheck = check.getPreferredSize();
            Dimension dLabel = label.getPreferredSize();
            return new Dimension(dCheck.width + dLabel.width, dCheck.height < dLabel.height ? dLabel.height : dCheck.height);
        }

    }

    @Override
    public void doLayout() {
        if (!check.isVisible()) {
            Dimension dLabel = label.getPreferredSize();
            int yLabel = 0;
            label.setLocation(0, yLabel);
            label.setBounds(0, yLabel, dLabel.width, dLabel.height);
        } else {
            Dimension dCheck = check.getPreferredSize();
            Dimension dLabel = label.getPreferredSize();
            int yCheck = 0;
            int yLabel = 0;
            if (dCheck.height < dLabel.height)
                yCheck = (dLabel.height - dCheck.height) / 2;
            else
                yLabel = (dCheck.height - dLabel.height) / 2;
            check.setLocation(0, yCheck);
            check.setBounds(0, yCheck, dCheck.width, dCheck.height);
            label.setLocation(dCheck.width, yLabel);
            label.setBounds(dCheck.width, yLabel, dLabel.width, dLabel.height);
        }

    }

    @Override
    public void setBackground(Color color) {
        if (color instanceof ColorUIResource)
            color = null;
        super.setBackground(color);
    }
}