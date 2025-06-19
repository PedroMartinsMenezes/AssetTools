namespace AssetTool
{
    [JsonAsset("PersonaOptions")]
    public class UPersonaOptions : UObject
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}