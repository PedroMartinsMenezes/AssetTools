namespace AssetTool
{
    [JsonAsset("AssignDebugVisProcessor")]
    public class UAssignDebugVisProcessor : UMassObserverProcessor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}