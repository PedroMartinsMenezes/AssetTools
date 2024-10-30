namespace AssetTool
{
    [JsonAsset("MaterialGraphSchema")]
    public class UMaterialGraphSchema : UEdGraphSchema
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}