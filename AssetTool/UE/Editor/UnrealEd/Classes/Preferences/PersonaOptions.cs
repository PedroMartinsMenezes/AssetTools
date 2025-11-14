namespace AssetTool
{
    [JsonAsset("PersonaOptions")]
    public class UPersonaOptions : UObject
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}