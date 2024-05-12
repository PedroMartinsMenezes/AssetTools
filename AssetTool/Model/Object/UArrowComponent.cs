namespace AssetTool
{
    public class UArrowComponent : UPrimitiveComponent
    {
        public new const string TypeName = "ArrowComponent";

        public new UArrowComponent Move(Transfer transfer) => (UArrowComponent)base.Move(transfer);
    }
}
