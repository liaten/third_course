namespace app7._5._1
{
    public class HugeInteger
    {
        byte[] its_nums = new byte[40];
        byte its_length = 0;
        bool is_positive = true;
        public HugeInteger(string hugeint)
        {
            this.its_length = (byte)hugeint.Length;
            for (byte i = 0; i < its_length; i++)
            {
                this.its_nums[its_length - i - 1] = Convert.ToByte(hugeint.Substring(i, 1));
            }
            for (byte i = its_length; i < 40; i++)
            {
                this.its_nums[i] = 0;
            }
        }
        ~HugeInteger()
        {
            // Деструктор класса HugeInteger
        }
        private void Recount_Length()
        {
            byte length = 0;
            for (byte i = 0; i < 40; i++)
            {
                if (its_nums[i] != 0)
                {
                    length = i;
                    length++;
                }
            }
            if (length == 0)
            {
                length = 1;
            }
            this.its_length = length;
        }
        public void Print()
        {
            if (!this.is_positive)
            {
                Console.Write("-");
            }
            for (byte i = 0; i < this.its_length; i++)
            {
                Console.Write(its_nums[this.its_length - i - 1]);
            }
        }
        public string Get()
        {
            string returning = "";
            if (!this.is_positive)
            {
                returning += "-";
            }
            for (byte i = 0; i < this.its_length; i++)
            {
                returning += this.its_nums[this.its_length - i - 1];
            }
            return returning;
        }
        public static HugeInteger operator +(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            HugeInteger sum;
            if (l1 > l2)
            {
                sum = new HugeInteger(hi1.Get());
                for (byte i = 0; i < l1; i++)
                {
                    sum.its_nums[i] += hi2.its_nums[i];
                    if (sum.its_nums[i] > 9 && (i + 1) < 40)
                    {
                        sum.its_nums[i + 1]++;
                        sum.its_nums[i] -= 10;
                    }
                }
            }
            else
            {
                sum = new HugeInteger(hi2.Get());
                for (byte i = 0; i < l2; i++)
                {
                    sum.its_nums[i] += hi1.its_nums[i];
                    if (sum.its_nums[i] > 9 && (i + 1) < 40)
                    {
                        sum.its_nums[i + 1]++;
                        sum.its_nums[i] -= 10;
                    }
                }
            }
            sum.Recount_Length();
            return sum;
        }
        public static HugeInteger operator -(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            HugeInteger diff;
            if (hi1 > hi2)
            {
                diff = new HugeInteger(hi1.Get());
                for (byte i = 0; i < l1; i++)
                {
                    if (diff.its_nums[i] >= hi2.its_nums[i])
                    {
                        diff.its_nums[i] -= hi2.its_nums[i];
                    }
                    else if (diff.its_nums[i + 1] > 0 && (i + 1) < 40)
                    {
                        diff.its_nums[i] = (byte)(diff.its_nums[i] + 10 - hi2.its_nums[i]);
                        diff.its_nums[i + 1]--;
                    }
                    else if (i + 2 < l1)
                    {
                        byte k = i;
                        k += 2;
                        while (k < l1)
                        {
                            if (diff.its_nums[k] > 0)
                            {
                                diff.its_nums[k]--;
                                for (byte j = (byte)(k - 1); j > i; j--)
                                {
                                    diff.its_nums[j] = 9;
                                }
                                break;
                            }
                            else
                            {
                                k++;
                            }
                        }
                    }
                }
            }
            else if (hi2 > hi1)
            {
                diff = new HugeInteger(hi2.Get());
                diff.is_positive = false;
                for (byte i = 0; i < l2; i++)
                {
                    if (diff.its_nums[i] >= hi1.its_nums[i])
                    {
                        diff.its_nums[i] -= hi1.its_nums[i];
                    }
                    else if (diff.its_nums[i + 1] > 0 && (i + 1) < 40)
                    {
                        diff.its_nums[i] = (byte)(diff.its_nums[i] + 10 - hi1.its_nums[i]);
                        diff.its_nums[i + 1]--;
                    }
                    else if (i + 2 < l2)
                    {
                        byte k = i;
                        k += 2;
                        while (k < l2)
                        {
                            if (diff.its_nums[k] > 0)
                            {
                                diff.its_nums[k]--;
                                for (byte j = (byte)(k - 1); j > i; j--)
                                {
                                    diff.its_nums[j] = 9;
                                }
                                break;
                            }
                            else
                            {
                                k++;
                            }
                        }
                    }
                }
            }
            else
            {
                return new HugeInteger("0");
            }
            diff.Recount_Length();
            return diff;
        }
        public static HugeInteger operator *(HugeInteger hi1, HugeInteger hi2)
        {
            if (hi1.isZero() || hi2.isZero())
            {
                return new HugeInteger("0");
            }
            else if (hi1.Get() == "1")
            {
                return hi2;
            }
            else if (hi2.Get() == "1")
            {
                return hi1;
            }
            else
            {
                byte l1 = hi1.its_length;
                byte l2 = hi2.its_length;
                HugeInteger multi = new HugeInteger("0");
                HugeInteger prom;
                for (byte i = 0; i < l1; i++)
                {
                    prom = new HugeInteger("0");
                    for (byte j = 0; j < l2; j++)
                    {
                        byte result = (byte)(hi1.its_nums[i] * hi2.its_nums[j]);
                        prom.its_nums[j + i] = (byte)(result % 10);
                        prom.its_nums[j + i + 1] = (byte)(result / 10);
                    }
                    prom.Recount_Length();
                    for(byte k = 0; k < prom.its_length; k++)
                    {
                        multi.its_nums[k] += (byte)(prom.its_nums[k]);
                        multi.its_nums[k+1] += (byte)(multi.its_nums[k] / 10);
                        multi.its_nums[k] = (byte)(multi.its_nums[k] % 10);
                    }
                }
                multi.Recount_Length();
                return multi;
            }
        }
        public static HugeInteger operator /(HugeInteger hi1, HugeInteger hi2)
        {
            if (hi1.isZero() || hi2.isZero())
            {
                throw new DivideByZeroException();
            }
            else if (hi2.Get() == "1")
            {
                return hi1;
            }
            else
            {
                byte l1 = hi1.its_length;
                byte l2 = hi2.its_length;
                HugeInteger multi = new HugeInteger("0");
                for (byte i = 0; i < l1; i++)
                {
                    for (byte j = 0; j < l2; j++)
                    {
                        byte result = (byte)(hi1.its_nums[i] * hi2.its_nums[j]);
                        multi.its_nums[i] += (byte)(result % 10);
                        if (i + 1 < 40)
                        {
                            multi.its_nums[(i + 1)] += (byte)(result / 10);
                        }
                    }
                }
                multi.Recount_Length();
                return multi;
            }
        }
        public static bool operator >(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            if (l1 > l2)
            {
                return true;
            }
            else if (l1 < l2)
            {
                return false;
            }
            else
            {
                for (int i = l1; i > 0; i--)
                {
                    if (hi1.its_nums[i] == hi2.its_nums[i])
                    {
                        continue;
                    }
                    else if (hi1.its_nums[i] > hi2.its_nums[i])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
        public static bool operator >=(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            if (l1 > l2)
            {
                return true;
            }
            else if (l1 < l2)
            {
                return false;
            }
            else
            {
                for (int i = l1; i > 0; i--)
                {
                    if (hi1.its_nums[i] == hi2.its_nums[i])
                    {
                        continue;
                    }
                    else if (hi1.its_nums[i] > hi2.its_nums[i])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public static bool operator <=(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            if (l1 > l2)
            {
                return false;
            }
            else if (l1 < l2)
            {
                return true;
            }
            else
            {
                for (int i = l1; i > 0; i--)
                {
                    if (hi1.its_nums[i] == hi2.its_nums[i])
                    {
                        continue;
                    }
                    else if (hi1.its_nums[i] > hi2.its_nums[i])
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                return true;
            }
        }
        public static bool operator <(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            if (l1 < l2)
            {
                return true;
            }
            else if (l1 > l2)
            {
                return false;
            }
            else
            {
                for (int i = l1; i > 0; i--)
                {
                    if (hi1.its_nums[i] == hi2.its_nums[i])
                    {
                        continue;
                    }
                    else if (hi1.its_nums[i] < hi2.its_nums[i])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
        }
        public static bool operator ==(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            if (l1 == l2)
            {
                for (byte i = 0; i < l1; i++)
                {
                    if (hi1.its_nums[i] == hi2.its_nums[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(HugeInteger hi1, HugeInteger hi2)
        {
            byte l1 = hi1.its_length;
            byte l2 = hi2.its_length;
            if (l1 == l2)
            {
                for (byte i = 0; i < l1; i++)
                {
                    if (hi1.its_nums[i] == hi2.its_nums[i])
                    {
                        continue;
                    }
                    else
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool isZero()
        {
            if (this.its_length == 1 && this.its_nums[0] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
