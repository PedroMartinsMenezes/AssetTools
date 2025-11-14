namespace AssetTool
{
    [JsonAsset("CombinedTransformGizmoContextObject")]
    public class UCombinedTransformGizmoContextObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}