namespace AssetTool
{
    public class USpringArmComponent : USceneComponent
    {
        public new const string TypeName = "SpringArmComponent";

        public new USpringArmComponent Move(Transfer transfer) => (USpringArmComponent)base.Move(transfer);
    }
}
