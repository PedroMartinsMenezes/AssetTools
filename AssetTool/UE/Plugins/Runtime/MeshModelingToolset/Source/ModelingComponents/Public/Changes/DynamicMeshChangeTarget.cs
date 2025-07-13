namespace AssetTool
{
    [JsonAsset("DynamicMeshReplacementChangeTarget")]
    public class UDynamicMeshReplacementChangeTarget : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}