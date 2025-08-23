namespace AssetTool
{
    [JsonAsset("PlacedEditorUtilityBase")]
    public class ADEPRECATED_PlacedEditorUtilityBase : AActor
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}