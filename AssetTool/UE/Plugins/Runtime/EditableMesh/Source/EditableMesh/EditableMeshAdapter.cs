namespace AssetTool
{
    [JsonAsset("EditableMeshAdapter")]
    public class UEditableMeshAdapter : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}