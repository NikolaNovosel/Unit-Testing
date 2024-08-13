using UnitTesting;

namespace UnitTestingTests;

public class SequenceTests
{
    [TestCase(null, 0)]
    [TestCase("", 0)]
    [TestCase("?", 1)]
    [TestCase("5", 1)]
    [TestCase(" ", 1)]
    [TestCase("a", 1)]
    [TestCase("aa", 1)]
    [TestCase("bbb", 1)]
    [TestCase("aabbcc", 2)]
    [TestCase("aabbcdd", 3)]
    [TestCase("ab", 2)]
    [TestCase(" bc", 3)]
    [TestCase("abcc12234!", 4)]
    [TestCase("abc123.?!abc", 12)]
    public void CountMaxUnequalSequence(string? input, int expected)
    {
        int result = Sequence.CountMaxUnequalSequence(input);
        Assert.That(result, Is.EqualTo(expected));
    }
    

    [TestCase(null, 0)]
    [TestCase("", 0)]
    [TestCase(" ", 0)]
    [TestCase("?", 0)]
    [TestCase("5", 0)]
    [TestCase("№", 0)]
    [TestCase("a", 1)]
    [TestCase(" ", 0)]
    [TestCase("??", 0)]
    [TestCase("11", 0)]
    [TestCase("№№", 0)]
    [TestCase("aaaa", 4)]
    [TestCase("AAAA", 4)]
    [TestCase("aabbccddeeff", 2)]
    [TestCase("aaabbbccc", 3)]
    [TestCase("aaaAAA", 3)]
    [TestCase("aaAAbbBB", 2)]
    [TestCase("abcdefgh", 1)]
    [TestCase("aAbBcCdDeEfF", 1)]
    [TestCase("abcdaaabcdeaa", 3)]
    [TestCase("abcdaabcdeaaa", 3)]
    [TestCase("aaabcdaabcde", 3)]
    [TestCase("1234444aaa", 3)]
    [TestCase("1222!!!!aa!!!aaa////", 3)]
    [TestCase("aaωωω   ...@@@@bbb№№№ノノノ＞＞＞cccc＜＜＜｀｀｀、、、ヽヽヽ☂☂☂･･･^^^", 4)]
    public void CountMaxEqualSequenceAlphabet(string? input, int expected)
    {
        int result = Sequence.CountMaxEqualSequenceAlphabet(input);
        Assert.That(result, Is.EqualTo(expected));
    }

    [TestCase(null, 0)]
    [TestCase("", 0)]
    [TestCase(" ", 0)]
    [TestCase("?", 0)]
    [TestCase("5", 1)]
    [TestCase("a", 0)]
    [TestCase("aa", 0)]
    [TestCase("??", 0)]
    [TestCase("№№", 0)]
    [TestCase("1111", 4)]
    [TestCase("12233344", 3)]
    [TestCase("1223334455666677", 4)]
    [TestCase("122333444455555", 5)]
    [TestCase("987654321", 1)]
    [TestCase("1234111234511", 3)]
    [TestCase("1234112345111", 3)]
    [TestCase("111234112345", 3)]
    [TestCase("aabbb112233!!!", 2)]
    [TestCase("!!!1122!!2233aaa", 2)]
    [TestCase("abcd123456789?>1", 1)]
    [TestCase("aacd11123456789?>1bbb1111", 4)]
    public void CountMaxEqualSequenceDigit(string? input, int expected)
    {
        int result = Sequence.CountMaxEqualSequenceDigit(input);
        Assert.That(result, Is.EqualTo(expected));
    }
}