namespace AssetTool
{
    [JsonAsset("RigidBodyBase")]
    public class ARigidBodyBase : AActor
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}