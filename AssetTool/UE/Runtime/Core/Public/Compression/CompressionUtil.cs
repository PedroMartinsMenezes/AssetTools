namespace AssetTool
{
    public static class FCompressionUtil
    {
        public static void SerializeCompressorName(Transfer transfer, ref uint8 CompressorNum, ref FString CompressionFormatToDecode)
        {
            transfer.Move(ref CompressorNum);
            if (CompressorNum == 0)
            {
                transfer.Move(ref CompressionFormatToDecode);
            }
        }
    }
}
