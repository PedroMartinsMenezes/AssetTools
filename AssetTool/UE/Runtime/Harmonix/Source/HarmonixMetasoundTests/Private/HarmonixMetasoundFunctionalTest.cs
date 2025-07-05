namespace AssetTool
{
    [JsonAsset("HarmonixMetasoundFunctionalTestLibrary")]
    public class UHarmonixMetasoundFunctionalTestLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("HarmonixMetasoundFunctionalTest")]
    public class AHarmonixMetasoundFunctionalTest : AFunctionalTest
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}