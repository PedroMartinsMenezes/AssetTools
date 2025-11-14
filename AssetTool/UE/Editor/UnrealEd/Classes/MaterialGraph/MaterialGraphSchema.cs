namespace AssetTool
{
    [JsonAsset("MaterialGraphSchema")]
    public class UMaterialGraphSchema : UEdGraphSchema
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}