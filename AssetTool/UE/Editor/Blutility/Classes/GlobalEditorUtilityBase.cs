namespace AssetTool
{
    [JsonAsset("GlobalEditorUtilityBase")]
    public class UDEPRECATED_GlobalEditorUtilityBase : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}