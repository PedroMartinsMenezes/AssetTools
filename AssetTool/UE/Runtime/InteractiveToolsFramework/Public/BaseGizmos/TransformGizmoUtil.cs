namespace AssetTool
{
    [JsonAsset("CombinedTransformGizmoContextObject")]
    public class UCombinedTransformGizmoContextObject : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}