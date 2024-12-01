namespace AssetTool
{
    [JsonAsset("RigidBodyBase")]
    public class ARigidBodyBase : AActor
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}