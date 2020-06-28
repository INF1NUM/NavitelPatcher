using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace NavitelPatcher
{
    class FilePatcher
    {
        private string filePath;
        private byte[] fileContent;

        public void ReadFile(string path)
        {
            // Read file bytes.
            fileContent = File.ReadAllBytes(path);
            filePath = path;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private bool CheckPatch(byte[] sequence, int position, byte[] pattern)
        {
            if (position + pattern.Length > sequence.Length) return false;
            for (int p = 0; p < pattern.Length; p++)
                if (pattern[p] != sequence[position + p]) return false;
            return true;
        }

        public List<int> GetOffsets(byte[] mask)
        {
            List<int> offsets = new List<int>();
            for (int p = 0; p < fileContent.Length; p++)
            {
                if (!CheckPatch(fileContent, p, mask)) continue;
                offsets.Add(p);
            }
            return offsets;
        }

        public void PatchFile(int offset, byte[] data)
        {
            for (int i = 0; i < data.Length; i++)
                fileContent[offset + i] = data[i];
        }

        public void SaveFile()
        {
            SaveFileAs(filePath);
        }

        public void SaveFileAs(string path)
        {
            File.WriteAllBytes(path, fileContent);
        }

        public string FilePath { get { return filePath; } }
        public byte[] FileContent { get { return fileContent; } }
    }
}
