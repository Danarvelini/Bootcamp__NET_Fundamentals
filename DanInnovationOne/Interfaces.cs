interface IControl{
    void Paint();
}
interface IListBox{
    void SetText(string text);
}
interface IComboBox: IControl, IListBox{
    
}