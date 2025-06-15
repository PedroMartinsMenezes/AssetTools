namespace AssetTool
{
    [JsonAsset("NavModifierComponent")]
    public class UNavModifierComponent : UNavRelevantComponent
    {
        public override UObject Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}