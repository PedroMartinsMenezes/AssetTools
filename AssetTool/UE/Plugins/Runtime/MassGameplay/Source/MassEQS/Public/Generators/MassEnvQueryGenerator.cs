namespace AssetTool
{
    [JsonAsset("MassEnvQueryGenerator")]
    public class UMassEnvQueryGenerator : UEnvQueryGenerator
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}