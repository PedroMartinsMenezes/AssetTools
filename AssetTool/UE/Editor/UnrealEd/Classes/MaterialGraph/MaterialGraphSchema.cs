namespace AssetTool
{
    [JsonAsset("MaterialGraphSchema")]
    public class UMaterialGraphSchema : UEdGraphSchema
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}