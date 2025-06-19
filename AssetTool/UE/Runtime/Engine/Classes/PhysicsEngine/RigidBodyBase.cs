namespace AssetTool
{
    [JsonAsset("RigidBodyBase")]
    public class ARigidBodyBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}