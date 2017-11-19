import { Access } from './models';

export interface SaveEmployment{
    id: number;
    fullName: string;
    phone: string;
    email: string;
    startDate: Date;
    managerEmail: string;
    restrictedAccess: string;
    additionalInfo: string;
    additionalService: string;
    otherPosition: string;
    otherComapny: string;
    otherAccesses: string;
    otherServices: string;
    companyId: number;
    positionId: number;
    accesses: number[];
    equipments: number[];
}

export interface Employment{
    id: number;
    fullName: string;
    phone: string;
    email: string;
    company: string;
    position: string;
}

export class Employment{
    id: number;
    fullName: string;
    phone: string;
    email: string;
    company: string;
    position: string;
}

export interface Equipment {
    equipmentId: number;
    name: string;
}

export interface Position {
    positionId: number;
    name: string;
}

export interface Company {
    companyId: number;
    name: string;
}

export interface Access {
    accessId: number;
    name: string;
}