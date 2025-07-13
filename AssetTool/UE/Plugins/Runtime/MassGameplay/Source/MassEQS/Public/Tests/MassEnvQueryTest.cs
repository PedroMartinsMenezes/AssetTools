namespace AssetTool
{
    [JsonAsset("MassEnvQueryTest")]
    public class UMassEnvQueryTest : UEnvQueryTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}