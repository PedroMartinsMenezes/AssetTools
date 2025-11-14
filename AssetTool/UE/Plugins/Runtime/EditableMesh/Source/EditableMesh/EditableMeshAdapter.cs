namespace AssetTool
{
    [JsonAsset("EditableMeshAdapter")]
    public class UEditableMeshAdapter : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}