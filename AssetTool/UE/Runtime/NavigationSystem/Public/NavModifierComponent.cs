namespace AssetTool
{
    [JsonAsset("NavModifierComponent")]
    public class UNavModifierComponent : UNavRelevantComponent
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}