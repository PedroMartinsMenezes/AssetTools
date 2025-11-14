namespace AssetTool
{
    [JsonAsset("NavModifierComponent")]
    public class UNavModifierComponent : UNavRelevantComponent
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}