namespace AssetTool
{
    [JsonAsset("ControlRigShapeLibrary")]
    public class UControlRigShapeLibrary : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("ControlRigGizmoLibrary")]
    public class UControlRigGizmoLibrary : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}