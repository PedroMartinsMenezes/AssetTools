namespace AssetTool
{
    [JsonAsset("ModelObject")]
    public class UModelObject : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}