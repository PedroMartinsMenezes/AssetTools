namespace AssetTool
{
    [JsonAsset("MassEnvQueryTest")]
    public class UMassEnvQueryTest : UEnvQueryTest
    {
        public override ITransferable Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}