namespace AssetTool
{
    [JsonAsset("EnvQueryTest_Overlap")]
    public class UEnvQueryTest_Overlap : UEnvQueryTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}