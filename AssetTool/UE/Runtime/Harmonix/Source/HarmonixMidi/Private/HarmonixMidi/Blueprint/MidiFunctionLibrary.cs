namespace AssetTool
{
    [JsonAsset("MidiNoteFunctionLibrary")]
    public class UMidiNoteFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }

    [JsonAsset("MusicalTickFunctionLibrary")]
    public class UMusicalTickFunctionLibrary : UBlueprintFunctionLibrary
    {
        public override ITransferible Move(Transfer transfer)
        {
            return base.Move(transfer);
        }
    }
}